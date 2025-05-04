// object:
// base type for all types in C#

// TYPE:
// built-in type (reference)

// SYNTAX:
// object objectName = value;

// RETURNS:
// a reference to any type of object

// USES:
// storing any type when the specific type isn't known at compile time

namespace CSharpNotes.DataTypes.ReferenceTypes.ClassTypes
{
    internal class ObjectExample
    {
        public static object data = 42;

        public static void Run()
        {
            Console.WriteLine($"This is the string data type example: ");
            Console.WriteLine("string firstName = 'Caleb';");
            Console.WriteLine($"The variable data is type {data.GetType()} and has a value of {data}");
            Console.WriteLine();
        }
    }
}
