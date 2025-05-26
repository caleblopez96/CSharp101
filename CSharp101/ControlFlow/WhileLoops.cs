// while loops:
// loop that repeadtly executes a block of code as long as given condition is true

// KEY CONCEPTS:
// - pre-check loop: evals each condition before each iteration
// - runs zero or more times based on condition
// - must have logic to eventually make the condition false, else infinite loop

// SYNTAX:
/* 

  while(condition)
  {
    code to run
  }

*/

// USE CASES:
// - repeating task when you don't know how many times they'll need to run 
// - waiting for user input or program state change
// - processing collections or data until a stop condition is met

// NOTES:
// - if condition is false on the first check, code inside will not run
// - avoid infinite loops by ensuring the condition eventually becomes false
namespace CSharpNotes.ControlFlow
{
  public class WhileLoops
  {
    public static void Run()
    {
      Console.WriteLine("This is the while loop example");

      int count = 0;

      while (count < 5)
      {
        Console.WriteLine($"Count is: {count}");
        count++;
      }
      Console.WriteLine();
    }
  }
}