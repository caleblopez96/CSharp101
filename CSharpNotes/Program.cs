using CSharpNotes.Operators.ArithmeticOperators;
using CSharpNotes.Operators.AssignmentOperators;
using CSharpNotes.Operators.ComparisonOperators;
class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================");
        Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
        Console.WriteLine("Example: ArithmeticOperators.Run()");
        Console.WriteLine();
        AssignmentOperators.Run();
        ArithmeticOperators.Run();
        ComparisonOperators.Run();
        Console.Read();
    }
}
