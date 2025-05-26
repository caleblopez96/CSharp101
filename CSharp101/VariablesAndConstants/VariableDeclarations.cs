// Variable Declarations:
// variables allow you to define named storage locations in memory to hold values.

// KEY CONCEPTS:
// variables must have a name and a data type
// they can be declared explicitly (with a data type) or implicitly (with 'var')
// local variables require init before use

// SYNTAX:
// Explicit: [dataType] variableName = value;
// Implicit: var variableName = value;

// EXAMPLE:
// int score = 100;
// var name = "Caleb";

namespace CSharpNotes.VariablesAndConstants
{
    internal class VariableDeclarations
    {
        public static void Run()
        {
            // Explicit typing:
            int myNumber = 6;
            string myName = "caleb";

            Console.WriteLine($"Explicit int: {myNumber}");
            Console.WriteLine($"Implicit string: {myName}");

            // Implicit typing:
            var lastYear = 2024;
            var school = "ASU";

            Console.WriteLine($"Implicit int: ${lastYear}");
            Console.WriteLine($"Implicit string: ${school}");

            Console.WriteLine();
        }
    }
}
