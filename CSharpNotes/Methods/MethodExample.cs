// Methods
// define a reusable block of code that performs a specific task when called

// KEY CONCEPTS:
// - methods are declared with a return type, method name, optional params, and a code block
// - methods HAVE TO return a value unless you use void
// - can be called (invoked) from other methods or classes

// SYNTAX:
/* 

returnType methodName(parameters)
{
  define the method and what it does here
}

*/

// USE CASES:
// - organizing code into reusable blocks 
// - performing calculations, actions, or operations
// - returning values to the caller

// NOTES:
// - method names use PascalCase (CalculateTotal)
// - the main method is the programs entry point
// - methods can have zero or more params
// - methods must be inside a class
namespace CSharpNotes.Methods
{
  public class MethodExample
  {
    // method with no return value
    public static void SayHello()
    {
      Console.WriteLine("Hello");
    }

    // method that returns int
    public static int AddTwo(int a, int b)
    {
      return a + b;
    }

    public static void Run()
    {
      Console.WriteLine("This is the method example");
      SayHello();

      int sum = AddTwo(5, 10);
      Console.WriteLine($"The value of sum is: {sum}");
    }
  }
}