// double:
// use the double keyword to declare a double-precision floating-point number
// 64-bit floating-point number (~+/-5.0e-324 to +/-1.7e308)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// double doubleName = value;

// RETURNS:
// a double-precision floating-point number

// USES:
// storing fractional numbers where higher precision is needed 
namespace CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes
{
    internal class DoubleExample
    {
        // EXAMPLE:
        public static double gravity = 9.80665;

        public static void Run()
        {
            Console.WriteLine($"This is the double data type example: ");
            Console.WriteLine("double gravity = 9.80665;");
            Console.WriteLine($"The variable gravity is type {gravity.GetType()} and has a value of {gravity}");
            Console.WriteLine();
        }
    }
}
