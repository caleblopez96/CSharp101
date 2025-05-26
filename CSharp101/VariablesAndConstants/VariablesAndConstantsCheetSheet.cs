// Summary Cheat Sheet:
// Quick reference for variable-related keywords and concepts in C#

// CATEGORY:
// Variables & Constants

// QUICK REFERENCE:

// VARIABLES:
// [dataType] variableName = value;
// Example: int age = 30;

// STATIC VARIABLES:
// static [dataType] variableName = value;
// Example: static int totalUsers = 0;

// CONSTANTS:
// const [dataType] constantName = value;
// Example: const double Pi = 3.14159;

// READONLY FIELDS:
// readonly [dataType] fieldName;
// Can be assigned at declaration or in a constructor
// Example: readonly string creationTime;

// NAMING RULES:
// camelCase → variables, parameters
// PascalCase → constants, methods, properties, classes
// _camelCase → private fields (optional convention)
// ALL_CAPS → legacy constants (rare in modern C#)

// EXAMPLES:
// int age = 25;
// static string AppName = "NoteApp";
// const double TaxRate = 0.0825;
// readonly DateTime createdAt;

// NOTES:
// - Constants are implicitly static
// - Static variables are shared across all instances of a class
// - Readonly fields can be set in a constructor but not changed later
// - Follow naming conventions for readability and consistency

namespace CSharpNotes.VariablesAndConstants
{
    internal class VariablesAndConstantsCheetSheet
    {
        public const string AppName = "NoteApp";
        public static int TotalUsers = 0;
        public readonly DateTime CreatedAt;

        public VariablesAndConstantsCheetSheet()
        {
            CreatedAt = DateTime.Now;
        }

        public static void Run()
        {
            Console.WriteLine("This is the summary cheat sheet example.");

            // Local variable
            int age = 25;
            Console.WriteLine($"User age: {age}");

            // Static variable
            TotalUsers++;
            Console.WriteLine($"Total Users: {TotalUsers}");

            // Constant
            Console.WriteLine($"App Name: {AppName}");

            // Readonly field example
            var instance = new VariablesAndConstantsCheetSheet();
            Console.WriteLine($"Created At: {instance.CreatedAt}");

            Console.WriteLine();
        }
    }
}
