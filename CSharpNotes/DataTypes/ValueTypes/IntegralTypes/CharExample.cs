// char:
// use the string keyword to declare a string

// TYPE:
// built-in type (primitive)

// SYNTAX:
// char charName = "value";

// RETURNS:
// a char

// USES:
// text data, messages, identifiers

namespace CSharpNotes.DataTypes.ValueTypes.IntegralTypes
{
    internal class CharExample
    {
        // EXAMPLE:
        public static char letterA = 'a';

        public static void Run()
        {
            Console.WriteLine($"This is the char data type example: ");
            Console.WriteLine("char letterA = 'a';");
            Console.WriteLine($"The variable letter A is type {letterA.GetType()} and has a value of {letterA}");
            Console.WriteLine();
        }
    }
}
