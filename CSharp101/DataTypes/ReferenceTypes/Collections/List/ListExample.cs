// TYPE: Generic Collection (List<T>)

// NAMESPACE: System.Collections.Generic

// SYNTAX: 
// OLD: List<T> listName = new List<T>();
// NEW: List<T> listName = [];

// RETURNS: A list of type T elements, dynamically resizable

// USES: When you need a flexible, type-safe, resizable collection

namespace CSharp101.DataTypes.ReferenceTypes.Collections.List
{
    public class ListExample
    {
        public static void Run()
        {
            // create a list of integers
            List<int> numList = [1, 2, 3, 4, 5];

            // add an element to the list
            numList.Add(6); // list is now: [1, 2, 3, 4, 5, 6]
            Console.WriteLine($"After Add: {string.Join(", ", numList)}");

            // remove an element by value
            numList.Remove(3); // ist is now: [1, 2, 4, 5, 6]
            Console.WriteLine($"After Remove: {string.Join(", ", numList)}");

            // remove an element by index
            numList.RemoveAt(2); // list is now: [1, 2, 5, 6]
            Console.WriteLine($"After RemoveAt(2): {string.Join(", ", numList)}");

            // accessing elements
            Console.WriteLine($"Element at index 2: {numList[2]}"); // 5

            // check if an item exists in the list
            bool containsSix = numList.Contains(6); // true
            Console.WriteLine($"Contains 6: {containsSix}");

            // find the index of a specific item
            int indexOfFive = numList.IndexOf(5); // 2
            Console.WriteLine($"Index of 5: {indexOfFive}");

            // get the total count of items
            Console.WriteLine($"List count: {numList.Count}"); // 4

            // sort the list
            numList.Sort(); // List is now: [1, 2, 5, 6]
            Console.WriteLine($"After Sort: {string.Join(", ", numList)}");

            // clear the list
            numList.Clear(); // List is now empty: []
            Console.WriteLine($"After Clear: {string.Join(", ", numList)}");
        }
    }
}