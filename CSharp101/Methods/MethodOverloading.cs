// Method Overloading:
// defining multiple methods with the same name bit different parameter lists (type, number or order)

// KEY CONCEPTS:
// - methods can have the same name as long as their parameter list differs in:
//    - number of params
//    - type of params
//    - order of params
// - the correct version of the method is chosen at compile time based on the arguments passed
// - return type alone cannot differentiate overloaded methods

// EXAMPLE:
// void Print()
// void Print(string message)
// void Print(int number)
// void Print(string message, int time)

// USE CASES:
// - provide different ways to call a method for flexibility
// - avoid making multiple unrelated method names for similar actions
// - clean, organized code that adapts to different input needs

// NOTES:
// - methods must differ in param signature, not just return type
// - overlaoding improves code readability and reusability
// - often used in libraries and APIs

namespace CSharpNotes.Methods
{
  public class MethodOverloading
  {
    // no params
    public static void Print()
    {
      Console.WriteLine("Default message");
    }

    // one string param
    public static void Print(string message)
    {
      Console.WriteLine($"Message: {message}");
    }

    // one int param 
    public static void Print(int number)
    {
      Console.WriteLine($"Number: {number}");
    }

    // one int one string
    public static void Print(string message, int times)
    {
      for (int i = 0; i < times; i++)
      {
        Console.WriteLine($"Message: {message} printed: {times}");
      }
    }

    public static void Run()
    {
      Console.WriteLine("This is the method overloading example");
      Print();
      Print("Hello there");
      Print(6);
      Print("Repeat this line", 3);

      Console.WriteLine();
    }
  }
}