// decimal:
// use the decimal keyword to declare a variable of decimal type
// 128-bit floating-point number (+/-1.0 x 10-28 to +/-7.9 x 10^28)
// high-precision, base-10 floating-point type

// TYPE:
// built-in type (primitive)

// SYNTAX:
// decimal decimalName = valueM;

// RETURNS:
// a high-precision decimal number

// USES:
// financial and monetary calculations requiring exact precision

namespace CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes
{
    internal class DecimalExample
    {
        public static decimal price = 99.99M;

        public static void Run()
        {
            Console.WriteLine($"This is the decimal data type example: ");
            Console.WriteLine("decimal price = 99.99M;");
            Console.WriteLine($"The variable price is type {price.GetType()} and has a value of {price}");
            Console.WriteLine();
        }
    }
}
