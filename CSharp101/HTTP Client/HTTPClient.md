You need to create a new http client when attempting to make http requests. Here is a bare bones snippet to make request to an API:

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientExample
{
    class Program
    {
        private HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }

        async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(response);
        }
    }
}
```
