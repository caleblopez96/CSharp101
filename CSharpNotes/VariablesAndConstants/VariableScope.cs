// Variable Scope:
// defines where a variable can be accessed

// KEY CONCEPTS:
// C# has four main scopes:
// 1. Local scope - variables inside a method/block
// 2. Class/Instance scope - as a field of a class
// 3. Parameter scope - within method params
// 4. Global/Static scope - static variables accessible without creating an instance
// variables are only accessible within their scope

// SYNTAX:
// Local Scope: [dataType] variableName = value;
// Class Field: [accessModifier] [dataType] variableName;
// Static: static [dataType] variableName;

// EXAMPLES:
// int localNumber = 10;
// private string className;
// public static bool isActive;

namespace CSharpNotes.VariablesAndConstants
{
    internal class VariableScope
    {
        // class/instance scope
        private string classLevelMessage = "I am a class-level variable.";

        // static (global) scope
        public static int globalCount = 0;

        public static void Run()
        {
            Console.WriteLine("This is the variable scope example: ");

            // local scope
            int localNumber = 10;
            Console.WriteLine($"Local Variable: {localNumber}");

            // parameter scope
            DisplayParameterScope("Hello from a param");

            // accessing static variable
            Console.WriteLine($"Global/static variable: {globalCount}");
        }
        public static void DisplayParameterScope(string parameterName)
        {
            Console.WriteLine($"Parameter variable: {parameterName}");
        }
    }
}
