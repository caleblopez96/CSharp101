# C# JSON Deserialization Notes

## What is Deserialization?

**Deserialization** - the process of taking data like a JSON string and turning it into a usable C# object

## Why Do We Deserialize JSON?

JSON-to-C# object mapping serves several important purposes:

1. **Type Safety**: Instead of working with raw JSON strings, you get compile-time checking and IntelliSense
2. **Easier Data Access**: You can write `order.Customer.Name.FirstName` instead of parsing JSON manually
3. **Validation**: The `required` keyword ensures essential properties are present
4. **Maintainability**: Changes to the data structure are caught at compile time
5. **Performance**: Direct object access is faster than repeatedly parsing JSON

## Step-by-Step Guide

### Example JSON:

```json
{
  "id": 5,
  "name": "Caleb"
}
```

### Step 1: Define Your Model Class

Build your models based on the data being returned from the JSON:

```csharp
public class User
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
```

**Important Notes:**

- Use the `JsonPropertyName("property_name")` attribute when the JSON key doesn't match your C# property name
- This attribute is optional if the JSON property name matches your C# property name exactly
- The `required` keyword ensures the property must have a value during deserialization

### Step 2: Get Your JSON String

```csharp
string response = await client.GetStringAsync("https://apiendpoint.com");
```

### Step 3: Deserialize the JSON into Your Model

```csharp
User user = JsonSerializer.Deserialize<User>(response);
```

**What happens during deserialization:**

- Deserializer reads the JSON string (response)
- Looks for keys like "id" and "name" based on your defined model
- Finds matching properties in your C# class
- Converts values to the correct C# types
- Assigns the values to a new User object

### Step 4: Use the Deserialized Object

```csharp
Console.WriteLine($"User ID: {user.Id}"); // Output: User ID: 5
Console.WriteLine($"User Name: {user.Name}"); // Output: User Name: Caleb
```

## Complete API Service Example

```csharp
using System.Text.Json;

namespace HttpClientExample
{
    public class OrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Method to get orders - returns your C# objects
        public async Task<List<OrderResponse.Order>> GetOrdersAsync()
        {
            try
            {
                // 1. Make the API call
                var response = await _httpClient.GetAsync("https://api.example.com/orders");

                // 2. Check if successful
                response.EnsureSuccessStatusCode();

                // 3. Get the JSON string
                var jsonString = await response.Content.ReadAsStringAsync();

                // 4. Deserialize into your C# objects
                var apiResponse = JsonSerializer.Deserialize<OrderResponse.ApiResponse>(jsonString);

                // 5. Return the data you actually want
                return apiResponse?.Orders ?? new List<OrderResponse.Order>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Error: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON Parsing Error: {ex.Message}");
                throw;
            }
        }

        // Method to get a specific order by ID
        public async Task<OrderResponse.Order?> GetOrderByIdAsync(int orderId)
        {
            var orders = await GetOrdersAsync();
            return orders.FirstOrDefault(o => o.OrderId == orderId);
        }
    }
}
```

## Error Handling Best Practices

Always include error handling when deserializing JSON:

```csharp
try
{
    User user = JsonSerializer.Deserialize<User>(response);
    Console.WriteLine($"User ID: {user.Id}");
}
catch (JsonException ex)
{
    Console.WriteLine($"Failed to parse JSON: {ex.Message}");
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"HTTP request failed: {ex.Message}");
}
```

## Important Class Naming Rules

### Root Objects Don't Need JsonPropertyName

When you deserialize JSON, you specify which C# class represents the entire JSON structure:

```csharp
var response = JsonSerializer.Deserialize<ApiResponse>(jsonString);
//                                        ^^^^^^^^^^^
//                                This tells it "use ApiResponse as the root"
```

The class name itself doesn't matter for JSON mapping - it's just a container. You could name it anything:

```csharp
public class WhateverNameIWant  // ← Still works fine!
{
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    [JsonPropertyName("data")]
    public required List<Order> Orders { get; set; }
}
```

**Key Points:**

- **Class names**: Only matter to your C# code, not to JSON mapping
- **Property names**: Need `[JsonPropertyName]` if they don't match the JSON exactly
- The root object is special because you explicitly tell the deserializer which type to use

## Common Patterns You'll Use

- **GetOrdersAsync()** - Get all orders
- **GetOrderByIdAsync(id)** - Get one specific order
- **GetOrdersByCustomerAsync(customerId)** - Filter orders by customer
- **CreateOrderAsync(order)** - POST new orders
- **UpdateOrderAsync(order)** - PUT/PATCH existing orders
