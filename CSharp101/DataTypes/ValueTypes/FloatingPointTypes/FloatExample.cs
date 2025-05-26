// float:
// use the float keyword to declare a float
// 32-bit flaoting-point number (~+/-1.5e-45 to +/-3.4e38)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// float floatName = valueF;

// RETURNS:
// a single-precision floating-point number

// USES:
// storing fractional numbers where precision isn't critical(graphics, quick calculations)

namespace CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes
{
    internal class FloatExample
    {
        public static float pi = 3.14F;

        public static void Run()
        {
            Console.WriteLine("This is the float  data type example: ");
            Console.WriteLine("float pi = 3.14F;");
            Console.WriteLine($"The variable pi is type {pi.GetType()} and has a value of {pi}");
            Console.WriteLine();
        }
    }
}
