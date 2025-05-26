// int:
// use the int keyword to declare a 32-bit signed integer

// TYPE:
// built-in type (primitive)

// SYNTAX:
// int intName = value;

// RETURNS:
// an int value

// USES:
// default numeric type for whole numbers in most apps

namespace CSharpNotes.DataTypes.ValueTypes.IntegralTypes
{
    internal class IntExample
    {
        // EXAMPLE:
        public static int myNumber = 5;
        public static void Run()
        {
            Console.WriteLine("This is the int data type example: ");
            Console.WriteLine("int myNumber = 5;");
            Console.WriteLine($"The variable myNumber is type {myNumber.GetType()} and has the value of {myNumber}");
            Console.WriteLine();
        }

    }
}
