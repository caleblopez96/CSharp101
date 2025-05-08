using CSharpNotes.Classes;
using CSharpNotes.ControlFlow;
using CSharpNotes.DataTypes.ReferenceTypes.ListTypes;
using CSharpNotes.Methods;

class Program
{
  public static void Main()
  {
    Console.WriteLine("==========================");
    Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
    Console.WriteLine("Example: ArithmeticOperators.Run()");
    ListExample.Run();
    Console.WriteLine();
    Console.Read();
  }
}
