// sbyte: 
// 8-bit signed integer (-128 to 127)
// signed numbers 

// SYNTAX:
// sbyte sbyteName = value;

// RETURNS: 
// A sbyte value

// USES:
// use when small signed values are needed, like temperature or deltas
namespace CSharpNotes.DataTypes
{
    internal class SByteExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine("This is the sbyte example: ");
            sbyte temperature = -10;
            Console.WriteLine($"The temperature variable is type sbyte and the value is {temperature}");
            Console.WriteLine();
        }
    }
}
