// Naming Rules:
// Guidelines and conventions for naming variables, constants, fields, methods, and classes in c#

// KEY CONCEPTS:
// - names should be descriptive, consistent, and follow C# naming conventions
// - avoid reserved keywords
// - use camelCase for variables and parameters
// - use PascalCase for constants, methods, properties, and classes
// - use ALL_CAPS for constants in some legacy code (less common in modern C#)
// - Prefix private fields with an underscore is an accepted convention

// SYNTAX EXAMPLES:
// camelCase: int itemCount;
// PascalCase: class Student{}
// _camelCase (private fields): private int _totalCount;

// VALID NAMES:
// int userAge;
// string lastName;

// INVALID NAMES:
// int 2cool -> cannot start with a number
// string @class -> reserved keyword unless prefixed with @


namespace CSharpNotes.VariablesAndConstants
{
    internal class NamingRules
    {
        // camelCase for local variables
        public static int itemCount = 5;

        // Updated property with a default value
        public string ProductName { get; set; } = string.Empty;

        // _camelCase for private fields
        private int _internalCounter = 0;
        
        // Constant in PascalCase (modern C#)
        public const double TaxRate = 0.0825;

        public static void Run()
        {
            Console.WriteLine("This is the naming rules example");

            // displaying constant value
            Console.WriteLine($"The value of the constant is: {TaxRate}");

            // local variable in camelCase
            int itemCount = 3;
            Console.WriteLine($"Local itemCount: {itemCount}");

            Console.WriteLine();
        }
    }
}
