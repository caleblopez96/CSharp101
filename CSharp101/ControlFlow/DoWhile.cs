// do-while:
// loop that always execites its code block at least once, then repeats beased on given condition

// KEY CONCEPTS: 
// - post-check loop: runs the code first, then evals the condition
// - guaranteed to run at least once
// - must have logic to make condition false else infinite loop

// SYNTAX:
/* 

do
{
  code to do
} while (condition);

*/

// USE CASES:
// - when you need the code to run at least once before checking a condition
// - prompint user input and validating it
// - repeating operations with a confirmation step forward

// NOTES:
// - semicolon is requied after the while condition
// - avoid infinite loops by ensuring exit condition

namespace CSharpNotes.ControlFlow
{
  public class DoWhile
  {
    public static void Run()
    {
      Console.WriteLine("This is the do-while loop example");
      int count = 1;

      do
      {
        Console.WriteLine($"Count: {count}");
        count++;
      }
      while (count <= 5);
      Console.WriteLine();
    }
  }
}