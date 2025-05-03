// uint:
// 32-bit unsigned integer (0 to 4,294,967,295)

// SYNTAX:
// uint uintName = value;

// RETURNS:
// a uint value

// USES: large positive-only numbers like indexes or counters
namespace CSharp101.DataTypes
{
    public class UIntExample
    {
        public static void Run()
        {
            // EXAMPLE:
            Console.WriteLine($"This is the uint data type example: ");
            uint highScore = 300000;
            Console.WriteLine($"The variable highScore is type {highScore.GetType()} and its value is {highScore}");
            Console.WriteLine();
        }
    }
}
