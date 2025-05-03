// Byte: 
// 8-bit unsigned integer (0 to 255)
// unsigned numbers only hold positive numbers (and zeros)

// SYNTAX:
// byte byteName = value;

// RETURNS: 
// A byte value

// USES:
// storing small numbers like pixel values (0-255), flags, or raw binary data

namespace CSharpNotes.DataTypes
{
    internal class ByteExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine("This is the byte data example. The max value a byte can store is 255: ");
            byte age = 200;
            // byte invalidByte = 256; value cannot be converted to a byte
            Console.WriteLine($"The age variable is type byte with value {age}");
            Console.WriteLine();
        }
    }
}
