// for loops:
// execute a block of code a specific number of times based on specified conditions

// KEY CONCEPTS: 
// - pre-check loop: evals condition before each iteration
// - consist of three parts:
//    - initializer (int i = 0;)
//    - condition (i <= 10;)
//    - increment (i++;)

// SYNTAX:
/* 

for(initializer; condition; increment)
{
  code here
}

*/

// USE CASES:
// - looping a known number of times
// - iterating through arrays, list or other collections by index
// - performing operations with controlled start/end points

// NOTES:
// - you can use 'break' to exit early or 'continue' to skip to next iteration
namespace CSharpNotes.ControlFlow
{
  public class ForLoops
  {
    public static void Run()
    {
      Console.WriteLine("This is the for loop example");

      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine($"Inside of the for loop for the {i} time");
      }
    }
  }
}