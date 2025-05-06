using CSharpNotes.Classes;
using CSharpNotes.ControlFlow;
using CSharpNotes.Methods;

class Program
{
  public static void Main()
  {
    Console.WriteLine("==========================");
    Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
    Console.WriteLine("Example: ArithmeticOperators.Run()");
    ObjectInstantiation.Run();
    Console.WriteLine();
    Console.Read();
  }
}
