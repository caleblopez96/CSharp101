# HttpClient Usage Comparison in C#

This note compares two ways of making HTTP GET requests and deserializing JSON in C# using `HttpClient`.

---

## Setup

Make sure to include this using directive when using `GetFromJsonAsync<T>()`:

```csharp
using System.Net.Http.Json;
```

---

## WITHOUT `GetFromJsonAsync<T>()`

Manual HTTP GET request and JSON deserialization:

```csharp
string baseURL = "https://api.com";
string endpoint = "/users/id=1";

// Create new HttpClient instance
HttpClient client = new HttpClient();

// Send GET request
HttpResponseMessage response = await client.GetAsync(baseURL + endpoint);

// Read response content as string
string content = await response.Content.ReadAsStringAsync();

// Deserialize JSON string into a list of Car objects
List<Car> cars = JsonSerializer.Deserialize<List<Car>>(content);
```

---

## WITH `GetFromJsonAsync<T>()`

Simplified HTTP GET request that automatically deserializes JSON:

```csharp
string baseURL = "https://api.com";
string endpoint = "/users/id=1";

// Create new HttpClient instance
HttpClient client = new HttpClient();

// Send GET request and deserialize JSON response to list of Car objects
List<Car> cars = await client.GetFromJsonAsync<List<Car>>(baseURL + endpoint);
```

---

## Notes

- `GetFromJsonAsync<T>()` is an extension method from `System.Net.Http.Json` namespace.
- This method reduces boilerplate code and improves readability.
- Always dispose of `HttpClient` properly in real applications, or better yet, reuse it as a singleton.

---

## Example Car class for context

```csharp
public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}
```
