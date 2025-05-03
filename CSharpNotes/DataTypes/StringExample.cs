// strings:
// use the string keyword to declare a string

// SYNTAX:
// string stringName = "value";

// RETURNS:
// a string with the value passed

// USES: text data, messages, identifiers
namespace CSharp101.DataTypes
{
    internal class StringExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine($"This is the string data type example: ");
            string firstName = "Caleb";
            Console.WriteLine($"Hello! My first name is {firstName}");
            Console.WriteLine();
        }
    }
}
