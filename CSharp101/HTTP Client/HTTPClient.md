You need to create a new http client when attempting to make http requests. Here is a bare bones snippet to make request to an API:

```csharp
namespace HttpClientExample
{
  class program
  {
    HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
      Program program = new Program();
      await program.GetTodoItems();
    }

    static async Task GetTodoItems()
    {
      string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");

      Console.WriteLine(response);
    }
  }
}
```
