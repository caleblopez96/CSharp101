// Constants:
// A variable whose value is set at compile time and cannot be changed afterwords

// KEY CONCEPTS:
// - Declared with the 'const' keyword
// - Must be assigned a value when declared
// - Value is fixed and cannot be modified
// - Automatically static (can be accessed using the class name)

// SYNTAX:
// const [dataType] constantName = value;

// EXAMPLES:
// const double pi = 3.14159;
// const string appName = "MyApp";

// USES:
// defining fixed values like mathematical constants, app settings, or limits
// prevents accidental changes to important values

namespace CSharpNotes.VariablesAndConstants
{
    internal class ConstantsExample
    {
        public const double Pi = 3.14159;

        public static void Run()
        {
            Console.WriteLine("This is the constants example");

            Console.WriteLine($"The value of pi: {Pi}");

            // Pi = 3.14; NOT ALLOWED
            Console.WriteLine();
        }
    }
}
