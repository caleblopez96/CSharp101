// string:
// use the string keyword to declare a string

// TYPE:
// built-in type (primitive)

// SYNTAX:
// string stringName = "value";

// RETURNS:
// a string with the value passed

// USES:
// text data, messages, identifiers

namespace CSharpNotes.DataTypes.ReferenceTypes
{
    internal class StringExample
    {
        // EXAMPLE:
        public static string firstName = "Caleb";
        public static void Run()
        {
            Console.WriteLine($"This is the string data type example: ");
            Console.WriteLine("string firstName = 'Caleb';");
            Console.WriteLine($"The variable firstName is type {firstName.GetType()} and has a value of {firstName}");
            Console.WriteLine();
        }
    }
}
