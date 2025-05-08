// TYPE: Reference Type (String)

// NAMESPACE: System

// SYNTAX: 
// string variableName = "value";

// RETURNS: A sequence of characters

// USES: When working with text, messages, or character data

using System.ComponentModel;

namespace CSharpNotes.DataTypes.ReferenceTypes.StringType
{
  public class StringMethodsExample
  {
    public static void Run()
    {
      string greeting = "Hello World";

      // Length
      // SYNTAX:
      // string.Length

      // ARGS:
      // none

      // RETURNS:
      // length of string
      Console.WriteLine($"Length: {greeting.Length}"); // 11

      // ToUpper
      // SYNTAX:
      // string.ToUpper()

      // ARG
      Console.WriteLine($"ToUpper:  {greeting.ToUpper()}"); // "HELLO WORLD"

      // ToLower
      Console.WriteLine("ToLower: " + greeting.ToLower()); // "hello world"

      // Contains
      // SYNTAX:
      // string.Contains(value)

      // ARGS:
      // value - string to check if contains for

      bool hasHello = greeting.Contains("Hello");
      Console.WriteLine($"Contains 'Hello': {hasHello}"); // true

      // IndexOf
      int indexOfWorld = greeting.IndexOf("World");
      Console.WriteLine("Index of 'World': " + indexOfWorld); // 6

      // Replace
      string newGreeting = greeting.Replace("World", "CSharp");
      Console.WriteLine("After Replace: " + newGreeting); // "Hello CSharp"

      // Substring (like JS .slice)
      string sub = greeting.Substring(6, 5);
      Console.WriteLine("Substring(6,5): " + sub); // "World"

      // Split string into array (like JS .split)
      string[] words = greeting.Split(' ');
      Console.WriteLine("Split: " + string.Join(", ", words)); // "Hello, World"

      // Trim whitespace from both ends
      string spaced = "  spaced string  ";
      Console.WriteLine("Trim: '" + spaced.Trim() + "'");

      // Check if string starts with a substring
      Console.WriteLine("StartsWith 'Hello': " + greeting.StartsWith("Hello")); // true

      // Check if string ends with a substring
      Console.WriteLine("EndsWith 'World': " + greeting.EndsWith("World")); // true

      // Concatenate strings (like JS + or .concat)
      string combined = string.Concat(greeting, "!", " How are you?");
      Console.WriteLine("Concat: " + combined);

      // Repeat string (JS .repeat equivalent — no direct method, but with new string)
      string repeated = new string('*', 5);
      Console.WriteLine("Repeat '*': " + repeated); // "*****"

      // Check for null or empty
      Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(greeting)); // false

      // Check for null or whitespace
      Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace("   ")); // true

      // Convert to char array
      char[] charArray = greeting.ToCharArray();
      Console.WriteLine("Char Array: " + string.Join(", ", charArray));

      // Format string (like JS template literals)
      string name = "Chris";
      int age = 30;
      string message = string.Format("Name: {0}, Age: {1}", name, age);
      Console.WriteLine(message); // "Name: Chris, Age: 30"

      // Interpolated string (cleaner string formatting)
      string interpolated = $"Name: {name}, Age: {age}";
      Console.WriteLine(interpolated);
    }
  }
}
