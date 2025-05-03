// ulong:
// 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)

// SYNTAX:
// long longName = valueL;

// RETURNS:
// a long value

// USES: big numeric values like file sies, timestamps, population counts
namespace CSharpNotes.DataTypes
{
    internal class ULongExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine($"This is the ulong data type example: ");
            ulong dataSize = 50000000000L;
            Console.WriteLine($"The variable dataType is type {dataSize.GetType()} and has the value of {dataSize}");
            Console.WriteLine();
        }
    }
}
