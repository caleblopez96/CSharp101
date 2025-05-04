// func:
// a delegate type for a method that returns a value

// TYPE:
// built-in reference type

// SYNTAX:
// func<paramType1, paramType2, ..., returnType> funcName = MethodName;

// RETURNS:
// a value of the specified return type

// USES:
// pointing to and invoking methods that return a value

using CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes;

namespace CSharpNotes.DataTypes.ReferenceTypes.DelegateTypes
{
    internal class FuncExample
    {
        // Method to point to
        public static int AddNumbers(int a, int b) => a + b;
        public static void Run()
        {
            Console.WriteLine("This is the Func delegate example");
            Func<int, int, int> add = AddNumbers;
            int result = add(5, 10);
            Console.WriteLine($"Result of add(5, 10) = {result}");
            Console.WriteLine();
        }
    }
}
