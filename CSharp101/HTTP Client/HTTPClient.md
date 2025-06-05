You need to create a new http client when attempting to make http requests. Here is a bare bones snippet to make request to an API:

```csharp
namespace HttpClientExample
{
    class Program
    {
        readonly HttpClient client = new();

        static async Task Main()
        {
            Program program = new();
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            // get response
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");

            // read content from response
            string content = await response.Content.ReadAsStringAsync();

            // deserialize the JSON content
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

        class Todo
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
