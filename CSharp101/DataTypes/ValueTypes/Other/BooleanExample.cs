// boolean:
// use the bool keyword to declare a variable of type boolean

// TYPE:
// built-in type (primitive)

// SYNTAX:
// bool boolName = true/false

// RETURNS:
// a boolean value (t/f)

// USES:
// conditional logic, status flags, control flow

namespace CSharpNotes.DataTypes.ValueTypes.Other
{
    internal class BooleanExample
    {
        public static bool isValid = false;

        public static void Run()
        {
            Console.WriteLine($"This is the boolean data type example: ");
            Console.WriteLine("bool isValid = false;");
            Console.WriteLine($"The variable isValid is type {isValid.GetType()} and has a value of {isValid}");
            Console.WriteLine();
        }
    }
}
