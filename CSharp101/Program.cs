using HttpClientExample;
using System.Threading.Tasks;

class Program
{
  public static async Task Main()
  {
    Console.WriteLine("====================================================");
    HttpClientProgram example = new();
    await example.GetTodoItems();
  }
}
