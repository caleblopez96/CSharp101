// short:
// 16-bit unsigned integer (0 to 65,535)

// SYNTAX:
// ushort ushortName = value;

// RETURNS:
// a ushort value

// USES: Med-sized positive numbers, like object IDs or pixel counts

namespace CSharpNotes.DataTypes
{
    internal class UShortExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine("This is the ushort data type example: ");
            ushort points = 50000;
            Console.WriteLine($"The variable salary is type {points.GetType()} and has a value of ${points}");
            Console.WriteLine();
        }
    }
}