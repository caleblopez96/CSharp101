// int[]:
// array of integers

// TYPE:
// built-in reference type

// SYNTAX:
// int[] numbers = new int[] { 1, 2, 3 };
// OR
// int[] numbers = [1, 2, 3];

// RETURNS:
// an array containing multiple integer values

// USES:
// storing multiple numbers in a single collection
namespace CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes
{
    internal class IntArrayExample
    {
        public static int[] numbers = [1, 2, 3];

        public static void Run()
        {
            Console.WriteLine($"This is the int array data type example: ");
            Console.WriteLine("int[] numbers = [1, 2, 3]");
            Console.WriteLine($"The variable numbers is type {numbers.GetType()}");
            Console.WriteLine("Values:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
    }
}
