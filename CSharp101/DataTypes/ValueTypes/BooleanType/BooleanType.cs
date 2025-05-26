// bool:
// use the bool keyword to declare a variable of boolean type
// represents a logical value that can be either true or false
// 1 byte in memory (8 bits, but only uses 1 bit for the actual value)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// bool boolName = true/false;

// RETURNS:
// a boolean value (true or false)

// USES:
// conditional logic, flags, toggles, and control flow decisions

namespace CSharpNotes.DataTypes.ValueTypes.BooleanType
{
  internal class BooleanExample
  {
    public static bool isActive = true;
    public static bool isComplete = false;

    public static void Run()
    {
      Console.WriteLine($"This is the bool data type example: ");
      Console.WriteLine("bool isActive = true;");
      Console.WriteLine("bool isComplete = false;");
      Console.WriteLine($"The variable isActive is type {isActive.GetType()} and has a value of {isActive}");
      Console.WriteLine($"The variable isComplete is type {isComplete.GetType()} and has a value of {isComplete}");
      Console.WriteLine();

      // Demonstrating boolean operations
      Console.WriteLine("Boolean Operations:");
      bool result1 = isActive && isComplete;  // AND operation
      bool result2 = isActive || isComplete;  // OR operation
      bool result3 = !isActive;               // NOT operation

      Console.WriteLine($"isActive && isComplete = {result1}");
      Console.WriteLine($"isActive || isComplete = {result2}");
      Console.WriteLine($"!isActive = {result3}");
      Console.WriteLine();

      // Demonstrating conditional usage
      Console.WriteLine("Conditional Usage:");
      if (isActive)
      {
        Console.WriteLine("The system is active!");
      }

      if (!isComplete)
      {
        Console.WriteLine("The task is not complete yet.");
      }
      Console.WriteLine();

      // Demonstrating conversion from other types
      Console.WriteLine("Boolean Conversion Examples:");
      int number = 5;
      bool isPositive = number > 0;
      Console.WriteLine($"Is {number} positive? {isPositive}");

      string text = "Hello";
      bool hasContent = !string.IsNullOrEmpty(text);
      Console.WriteLine($"Does the string have content? {hasContent}");
      Console.WriteLine();
    }
  }
}