// arrays:
// use square brackets [] with a type to declare an array of that type

// TYPE:
// non-primitive (reference type)

// SYNTAX:
// int[] arrayName = new int[] { 1, 2, 3 };

// RETURNS:
// an array containing multiple values of the same type

// USES:
// storing multiple values in a single collection, grouping related data

namespace CSharpNotes.DataTypes.ReferenceTypes
{
    internal class ArrayExample
    {
        // EXAMPLE:
        public static int[] ints = new int[] { 1, 2, 3 };

        public static void Run()
        {
            Console.WriteLine("This is the array data type example:");
            Console.WriteLine("int[] ints = new int[] { 1, 2, 3 };");
            Console.WriteLine($"The variable ints is type {ints.GetType()} and has a length of {ints.Length}");
            Console.WriteLine("The values in the array are:");

            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }
    }
}
