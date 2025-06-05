You need to create a new http client when attempting to make http requests. Here is a bare bones snippet to make request to an API:

```csharp
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HttpClientExample
{
  public class HttpClientProgram
  {
    private readonly HttpClient client = new();

    public async Task GetTodoItems()
    {
      HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
      string content = await response.Content.ReadAsStringAsync();

      List<Todo>? todos = JsonSerializer.Deserialize<List<Todo>>(content);

      if (todos != null)
      {
        foreach (var todo in todos)
        {
          Console.WriteLine($"Todo: {todo.Title}: Completed: {todo.Completed}");
        }
      }
      else
      {
        Console.WriteLine("Failed to deserialize the response.");
      }
    }

    public class Todo
    {
      [JsonPropertyName("userId")]
      public int UserId { get; set; }

      [JsonPropertyName("id")]
      public int Id { get; set; }

      [JsonPropertyName("title")]
      public string? Title { get; set; }

      [JsonPropertyName("completed")]
      public bool Completed { get; set; }
    }
  }
}

```
