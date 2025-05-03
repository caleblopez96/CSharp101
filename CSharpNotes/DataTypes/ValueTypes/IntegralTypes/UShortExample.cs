// short:
// 16-bit unsigned integer (0 to 65,535)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// ushort ushortName = value;

// RETURNS:
// a ushort value

// USES:
// Med-sized positive numbers, like object IDs or pixel counts

namespace CSharpNotes.DataTypes.ValueTypes.IntegralTypes
{
    internal class UShortExample
    {
        // EXAMPLE:
        public static ushort points = 50000;
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine("This is the ushort data type example: ");
            Console.WriteLine("ushort points = 50000;");
            Console.WriteLine($"The variable points is type {points.GetType()} and has a value of ${points}");
            Console.WriteLine();
        }
    }
}