# C# JSON Deserialization with Models

## What is Deserialization?

**Deserialization** is the process of taking data (like a JSON string) and turning it into a usable C# object in your program.

## Example JSON:

```json
{
  "id": 12,
  "name": "Caleb"
}
```

## Step-by-Step Deserialization Process

### Step 1: Create a Model Class

This defines what properties you want from the JSON.

```csharp
public class User
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
```

**[JsonPropertyName("propertyName")]:**  
Maps the JSON key to your C# property (in case the names don't match exactly).

### Step 2: Create a JSON String

Could come from an API, file, or anywhere.

```csharp
string jsonString = "{ \"id\": 12, \"name\": \"Caleb\" }";
```

### Step 3: Deserialize the JSON into the Model

```csharp
User user = JsonSerializer.Deserialize<User>(jsonString);
```

**What happens here:**

- The deserializer reads the JSON string.
- Looks for keys like `id` and `name` because of the defined model.
- Finds matching properties in the `User` class.
- Converts values to the correct types.
- Assigns the values to a new `User` object.

### Step 4: Use the Deserialized Object

```csharp
Console.WriteLine(user.Id);    // Output: 12
Console.WriteLine(user.Name);  // Output: Caleb
```

## Important Notes:

- The mapping happens **by property name**, not by order/position.
- If JSON keys and C# property names differ, use `[JsonPropertyName]` to map them.
- Types must be compatible (e.g. don’t assign a string value to an int property).

## Example: Order Doesn't Matter

**This still works:**

```json
{
  "name": "Caleb",
  "id": 12
}
```

Because it matches by **key name**, not order.

## Working Example:

```csharp
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HttpClientExample
{
    class Program
    {
        HttpClient client = new();

        static async Task Main()
        {
            Program program = new();
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
          try
          {
              string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
              List<Todo>? todos = JsonSerializer.Deserialize<List<Todo>>(response);

              if (todos != null)
              {
                  foreach (var todo in todos)
                  {
                      Console.WriteLine($"Todo: {todo.Title}: Completed: {todo.Completed}");
                  }
              }
          }
          catch (HttpRequestException ex)
          {
              Console.WriteLine($"API call failed: {ex.Message}");
          }
          catch (JsonException ex)
          {
              Console.WriteLine($"JSON parsing failed: {ex.Message}");
          }
        }

        class Todo
        {
            [JsonPropertyName("userId")]
            public required int UserId { get; set; }

            [JsonPropertyName("id")]
            public required int Id { get; set; }

            [JsonPropertyName("title")]
            public required string? Title { get; set; }

            [JsonPropertyName("completed")]
            public required bool Completed { get; set; }
        }
    }
}
```
