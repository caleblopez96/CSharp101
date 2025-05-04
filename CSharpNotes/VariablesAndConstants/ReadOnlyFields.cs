// Readonly Fields:
// A field whose value can only be assigned at declaration or within a constructor

// KEY CONCEPTS:
// - Declared with the 'readonly' keyword
// - Value can be set at declaration or in a constructor
// - Cannot be modified elsewhere in the code
// - Useful when the value depends on constructor logic but should remain constant afterward

// SYNTAX:
// readonly [dataType] fieldName;

// EXAMPLE:
// readonly string appVersion = "1.0.0";
// readonly DateTime createdAt;

// USE CASES:
// setting values that should remain unchanged after object is created
// assigning values from constructor params

namespace CSharpNotes.VariablesAndConstants
{
    internal class ReadOnlyFields
    {
        public readonly string creationTime;

        // Constructor to set the readonly field
        public ReadOnlyFields()
        {
            creationTime = DateTime.Now.ToString("T");
        }

        public void DisplayCreationTime()
        {
            Console.WriteLine($"Object created at: {creationTime}");
        }

        public static void Run()
        {
            Console.WriteLine("This is the readonly field example");

            var example = new ReadOnlyFields();
            example.DisplayCreationTime();

            Console.WriteLine();
        }
    }
}
