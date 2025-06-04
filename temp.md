```csharp
namespace FinraApiExample
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var client = new HttpClient();
      client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY_HERE");

      var response = await client.GetAsync("https://api.finra.org/data/otcequity/volume");

      if (response.IsSuccessStatusCode)
      {
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
      }
      else
      {
        Console.WriteLine($"Error: {response.StatusCode}");
      }
    }
  }
}
```

// NASA example

```csharp
class Program
{
  static async Task Main(string[] args)
  {
    var client = new HttpClient();
  // client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY_HERE");

    var response = await client.GetAsync("https://api.nasa.gov/planetary/apod?api_key=FvWKdLmY53TwjEpAV1wcXmcQWxQ6iFkAkDcGRJOM");

    if (response.IsSuccessStatusCode)
    {
      var content = await response.Content.ReadAsStringAsync();
      Console.WriteLine(content);
    }
    else
    {
      Console.WriteLine($"Error: {response.StatusCode}");
    }
  }
}
```
