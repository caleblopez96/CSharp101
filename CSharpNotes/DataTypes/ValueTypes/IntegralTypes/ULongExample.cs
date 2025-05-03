// ulong:
// 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// long longName = valueL;

// RETURNS:
// a long value

// USES:
// big numeric values like file sies, timestamps, population counts
namespace CSharpNotes.DataTypes.ValueTypes.IntegralTypes
{
    internal class ULongExample
    {
        // EXAMPLE:
        public static ulong dataSize = 50000000000L;
        public static void Run()
        {
            Console.WriteLine($"This is the ulong data type example: ");
            Console.WriteLine("ulong dataSize = 50000000000L;");
            Console.WriteLine($"The variable dataType is type {dataSize.GetType()} and has the value of {dataSize}");
            Console.WriteLine();
        }
    }
}
