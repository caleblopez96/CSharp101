using CSharpNotes.Operators.ArithmeticOperators;
using CSharpNotes.Operators.UnaryOperators;

class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================");
        Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
        Console.WriteLine("Example: ArithmeticOperators.Run()");
        ArithmeticOperators.Run();
        UnaryOperators.Run();
        Console.WriteLine();
        Console.Read();
    }
}
