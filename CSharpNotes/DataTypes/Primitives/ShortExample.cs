// short:
// 16-bit signed integer (-32,768 to 32,767)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// short shortName = value;

// RETURNS:
// a short value

// USES: efficient storage of medium-sized signed numbers, like player health or scores

namespace CSharpNotes.DataTypes.Primitives
{
    internal class ShortExample
    {
        // EXAMPLE:
        public static short salary = 30000;
        public static void Run()
        {
            Console.WriteLine("This is the short data type example: ");
            Console.WriteLine("short salary = 30000;");
            Console.WriteLine($"The variable salary is type {salary.GetType()} and has a value of ${salary}");
            Console.WriteLine();
        }
    }
}