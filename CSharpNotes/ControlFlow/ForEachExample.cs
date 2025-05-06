// foreach: 
// a loop that iterates over each element in a collections

// KEY CONCEPTS:
// - pre-check loop: moves through each item in a colletion
// - handles initializer, condition and increment automatically behind the scenes
// - cant modify the collections elements directly in the loop

// SYNTAX:

/* 

foreach(var item in collection)
{
  code to run on each item
}

*/

// USE CASES:
// - reading or displaying the contents of a collection
// - performing an action for every element in the array or list
// - clearner, safer alternative to for loops when you dont need the index

// NOTES:
// - CAN'T modify the size or structure of a collection inside a foreach loop
// supports 'break' to exit early and 'continue' to skip to next iteration
// can iterate over arrays, lists, dictionaries (key-value pairs), and any type that implements IEnumerable

namespace CSharpNotes.ControlFlow
{
  public class ForEachExample
  {
    public static void Run()
    {
      Console.WriteLine("This is the foreach example: ");

      string[] names = ["John", "Bill", "Sarah"];

      foreach (var name in names)
      {
        Console.WriteLine($"Name: {name}");
      }
    }
  }
}