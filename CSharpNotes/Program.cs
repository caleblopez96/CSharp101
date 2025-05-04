using CSharpNotes.DataTypes.ReferenceTypes;
using CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes;
using CSharpNotes.DataTypes.ReferenceTypes.ClassTypes;
using CSharpNotes.DataTypes.ReferenceTypes.DelegateTypes;
using CSharpNotes.DataTypes.ReferenceTypes.InterfaceTypes;
using CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes;
using CSharpNotes.DataTypes.ValueTypes.IntegralTypes;
using CSharpNotes.DataTypes.ValueTypes.Other;
using CSharpNotes.Operators.ArithmeticOperators;
class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================");
        Console.WriteLine("You can use any object and run Object.Run() to get the confirmation to show");
        Console.WriteLine("Example: ArithmeticOperators.Run()");
        Console.WriteLine();
        ArithmeticOperators.Run();
        Console.Read();
    }
}
