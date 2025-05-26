// Parameters and Return Types
// define the inputs a method can receive and the type of value it sends back to the caller

// KEY CONCEPTS:
// - parameters: values passed into a method to be used inside it 
// - return type: the data type of the value a method gives back after running
// - use void when no value needs to be returned
// - multiple parameters are separated by commas in the parentheses

// SYNTAX:
/* 

returnType methodName(parameterType parameterName, ...)
{
  perform work on the params
  return a value
}

*/

// USE CASES:
// - passing values to a method for it to work with 
// - returning results after a calculation or operation
// - separating logic into clean, reusable methods

// NOTES:
// methods can have zero, one, or multiple parameters
// return types can be any data type (int, string, bool, custom classes, etc...)
// use return to return a value back from the method
// if a method doesn't return anything, it's void

namespace CSharpNotes.Methods
{
  public class ParametersAndReturnTypes
  {
    // method with one param
    public static void Greet(string name)
    {
      Console.WriteLine($"Hello, {name}!");
    }

    // method that returns a string
    public static string GetGreeting()
    {
      return "Hello there!";
    }

    // method with two params
    public static int Multiply(int a, int b)
    {
      return a * b;
    }

    public static void Run()
    {
      Console.WriteLine("This is an example of parameters and return types");

      Greet("John");

      string greeting = GetGreeting();
      Console.WriteLine(greeting);

      int sum = Multiply(3, 5);
      Console.WriteLine($"3 * 5 = {sum}");

      Console.WriteLine();
    }
  }
}