// uint:
// 32-bit unsigned integer (0 to 4,294,967,295)

// TYPE:
// built-in type (primitive)

// TYPE: 
// built-in type (primitive)

// SYNTAX:
// uint uintName = value;

// RETURNS:
// a uint value

// USES:
// large positive-only numbers like indexes or counters

namespace CSharpNotes.DataTypes.ValueTypes.IntegralTypes
{
    public class UIntExample
    {
        // EXAMPLE:
        public const uint highScore = 300000;
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine($"This is the uint data type example: ");
            Console.WriteLine("uint highScore = 300000;");
            Console.WriteLine($"The variable highScore is type {highScore.GetType()} and has a value of {highScore}");
            Console.WriteLine();
        }
    }
}
