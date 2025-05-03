// Byte: 
// 8-bit unsigned integer (0 to 255)
// unsigned numbers only hold positive numbers (and zeros)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// byte byteName = value;

// RETURNS: 
// A byte value

// USES:
// storing small numbers like pixel values (0-255), flags, or raw binary data

namespace CSharpNotes.DataTypes.Primitives
{
    internal class ByteExample
    {
        // EXAMPLE:
        public static byte age = 200;
        public static void Run()
        {
            Console.WriteLine("This is the byte data example.");
            Console.WriteLine("byte age = 200;");
            // byte invalidByte = 256; value cannot be converted to a byte
            Console.WriteLine($"The variable age is type {age.GetType()} with the value of {age}");
            Console.WriteLine();
        }
    }
}
