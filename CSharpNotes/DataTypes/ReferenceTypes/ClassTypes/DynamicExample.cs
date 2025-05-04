// dynamic:
// represents an object whose operations are resolved at runtime

// TYPE:
// built-in type (reference)

// SYNTAX:
// dynamic dynamicName = value;

// RETURNS:
// a value that bypasses compile-time type checking

// USES:
// interacting with dynamic data sources like JSON, COM objects, or reflection
namespace CSharpNotes.DataTypes.ReferenceTypes.ClassTypes
{
    internal class DynamicExample
    {
        public static dynamic value = 10;

        public static void Run()
        {
            Console.WriteLine($"This is the dynamic data type example: ");
            Console.WriteLine("dynamic value = 10;");
            Console.WriteLine($"The variable value is type {value.GetType()} and has a value of {value}");
            Console.WriteLine();
        }
    }
}
