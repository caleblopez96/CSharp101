// sbyte: 
// 8-bit signed integer (-128 to 127)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// sbyte sbyteName = value;

// RETURNS: 
// A sbyte value

// USES:
// use when small signed values are needed, like temperature or deltas

namespace CSharpNotes.DataTypes.Primitives
{
    internal class SByteExample
    {
        // EXAMPLE:
        public static sbyte temperature = -10;
        public static void Run()
        {
            Console.WriteLine("This is the sbyte data type example: ");
            Console.WriteLine("sbyte temperature = -10;");
            Console.WriteLine($"The variable temperature is type {temperature.GetType()} and has a value of {temperature}");
            Console.WriteLine();
        }
    }
}
