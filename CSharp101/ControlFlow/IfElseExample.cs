// if/else statements:
// conditional statement that executes different code blocks based on whether a condition is true or false

// KEY CONCEPTS:
// - executes code based on boolean condition
// - the if block runs a block if condition is true
// - else runs a block when no if condition was true
// - else if handles multiple specific conditions

// SYNTAX EXAMPLES:
// if (condition) 
// { 
//    condition if true
// } 
// else if
// {
//   check for another true condition
// }
// else
// {
//    condition if false
// }

// USE CASES:
// - decision making based on variables and states of the program
// - handling different outcomes or messages based on input
// - controlling program flow and branching logic 

// NOTES:
// else is optional
// else if can be chained for mutiple conditions
// conditions inside if statements must evaluate to a boolean

namespace CSharpNotes.ControlFlow
{
  internal class IfElseExample
  {
    public static void Run()
    {
      Console.WriteLine("This is the if/else control flow statement example:");

      Console.Write("Enter your score: ");
      // get the user input
      string input = Console.ReadLine();

      // parse the input into int
      if (int.TryParse(input, out int score))
      {
        if (score >= 90)
        {
          Console.WriteLine("Grade: A");
        }
        else if (score >= 80)
        {
          Console.WriteLine("Grade: B");
        }
        else if (score >= 70)
        {
          Console.WriteLine("Grade: C");
        }
        else if (score >= 60)
        {
          Console.WriteLine("Grade: D");
        }
        else
        {
          Console.WriteLine("Grade: F");
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a number.");
      }
    }
  }
}
