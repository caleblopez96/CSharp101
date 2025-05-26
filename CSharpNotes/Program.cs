using CSharpNotes.DataTypes.ValueTypes.CharType;
using CSharpNotes.DataTypes.ValueTypes.EnumTypes;

class Program
{
  public static void Main()
  {
    Console.WriteLine("==========================");
    Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
    Console.WriteLine("Example: ArithmeticOperators.Run()");
    EnumExample.Run();
    Console.WriteLine();
    Console.Read();
  }
}
