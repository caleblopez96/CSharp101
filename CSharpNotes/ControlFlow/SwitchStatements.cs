// switch Statements:
// a control statement that selects one of many code blocks to execute based on the value of a variable.

// KEY CONCEPTS:
// - compares a single value against multiple possible match cases
// - executes the block under the matching case
// - the default block runs if no case matches
// - break statements are used to exit each case

// SYNTAX EXAMPLES:
/* 

switch (variable)
{
    case value1:
        code if variable == value1
        break;
    case value2:
        code if variable == value2
        break;
    default:
        code if no case matches
        break;
}

*/

// USE CASES:
// - simplifying multiple value checks
// - replacing long chains of if-else statements when checking one variable
// - cleaner handling of enums, integers, strings, and char comparisons

// NOTES:
// - each case must end with break or other flow control (like return)
// - default is optional, acts like an else
// - modern C# also supports switch expressions (covered separately)

namespace CSharpNotes.ControlFlow
{
  internal class SwitchStatements
  {
    public static void Run()
    {
      Console.WriteLine("This is the switch statement example.");

      int day = 3;

      switch (day)
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        default:
          Console.WriteLine("Other Day");
          break;
      }
      Console.WriteLine();
    }
  }
}
