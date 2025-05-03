// long:
// 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)

// SYNTAX:
// long longName = valueL;

// RETURNS:
// a long value

// USES: big numeric values like file sies, timestamps, population counts
namespace CSharpNotes.DataTypes
{
    internal class LongExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine($"This is the long data type example: ");
            long population = 8250000000L;
            Console.WriteLine($"The variable population is type {population.GetType()} and has the value of {population}");
            Console.WriteLine();
        }
    }
}
