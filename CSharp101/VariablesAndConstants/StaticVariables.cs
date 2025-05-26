// static variables:
// variables that belong to the class itself rather than to instances of the class

// KEY CONCEPTS:
// - Shared across all instances of a class
// - Declared with 'static' keyword
// - Can be accessed using the class name without creating an object
// - Lifetime lasts the entire duration of the program

// SYNTAX:
// static [dataType] variableName = value;

// EXAMPLES:
// static int count = 0;
// static string appName = "MyApp";

// USE CASES:
// storing global values like config settings
// keeping track of values shared across all instances (like number of users, total orders)

namespace CSharpNotes.VariablesAndConstants
{
    internal class StaticVariables
    {
        public static int totalUsers = 0;

        public static void Run()
        {
            Console.WriteLine("This is the static variable example");

            // accessing and modifying the static variable
            Console.WriteLine($"Initial totalUsers = {totalUsers}");
            totalUsers++;
            Console.WriteLine($"Updated totalUsers = {totalUsers}");

            // accessing static variable without an instance
            Console.WriteLine($"Access via class name: {StaticVariables.totalUsers}");

            Console.WriteLine();
        }
    }
}
