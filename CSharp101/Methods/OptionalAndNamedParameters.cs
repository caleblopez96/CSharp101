// Optional and Named Parameters:
// allows methods to have parameters with default values (optional) and lets you specify arguments by name(named)

// KEY CONCEPTS:
// - optional parameter: parameter with a default value
// - named parameter: specify the name of the paramter when calling the method making it clear what value is for what argument
// - optional parameters must come after requierd ones 

// SYNTAX:
/* 

void MethodName(string name, int age = 21)
{
  method body
}

MethodName("John");
MethodName("Sarah", 25);
MethodName(age: 40, name: "Mike")

*/

// USE CASES:
// - simplify method overloading by reducing the need for multiple overloads
// - improve code readability and flexibility when calling themods with many params
// - set default values for parameters you dont always need to specify

// NOTES:
// - optional parameters MUST appear AFTER required params when defining method
// - named params let you pass arguments in any order, as long as you specify their names
// - can mix positional and named arguments, but named ones should come after psotional unless they're all named

namespace CSharpNotes.Methods
{
  public class OptionalAndNamedParameters
  {
    // method with optional param greeting (optional because it already has a default value)
    public static void Greet(string name, string greeting = "Hello")
    {
      Console.WriteLine($"{greeting}, {name}!");
    }

    public static void Run()
    {
      Console.WriteLine("This is the optional and named parameters example");

      // using default value for optional param
      Greet("John"); // "Hello, John!

      // providing custom value for greeting
      Greet("John", "Greetings"); // "Greetings, John!"

      // using named arguments
      Greet(name: "John", greeting: "Hello there"); // Hello there, John!
    }
  }
}