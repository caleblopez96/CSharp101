// string[]:
// array of strings

// TYPE:
// built-in reference type

// SYNTAX:
// string[] words = new String[] {"word1", "word2", "word3"};
// OR
// string[] words = ["word1", "word2", "word3"];

// RETURNS:
// an array containing multiple string values

// USES:
// storing multiple text values in a collection

namespace CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes
{
    internal class StringArrayExample
    {
        public static string[] words = ["word1", "word2", "word3"];

        public static void Run()
        {
            Console.WriteLine($"This is the string array data type example: ");
            Console.WriteLine("string[] words = ['word1', 'word2', 'word3']");
            Console.WriteLine($"The variable words is type {words.GetType()}");
            Console.WriteLine("Values:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }
}
