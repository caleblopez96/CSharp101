// IEnumerable:
// interface for iterating over a collection

// TYPE:
// built-in reference type (interface)

// SYNTAX:
// IEnumerable<Type> collectionName = collection;

// RETURNS:
// an enumerable collection

// USES:
// allows looping through a collection using foreach

namespace CSharpNotes.DataTypes.ReferenceTypes.InterfaceTypes
{
    internal interface IEnumerableExample
    {
        public static IEnumerable<int> numbers = [1, 2, 3];

        public static void Run()
        {
            Console.WriteLine("THis is the IEnumerable example.");
            Console.WriteLine("IEnumerable numbers = new int[] { 1, 2, 3 }");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
