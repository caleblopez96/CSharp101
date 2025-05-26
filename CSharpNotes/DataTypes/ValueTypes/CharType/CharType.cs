// char:
// use the char keyword to declare a variable of character type
// represents a single Unicode character (UTF-16)
// 2 bytes in memory (16 bits)

// TYPE:
// built-in type (primitive)

// SYNTAX:
// char charName = 'character';

// RETURNS:
// a single Unicode character

// USES:
// storing single characters, character manipulation, parsing text character by character

namespace CSharpNotes.DataTypes.ValueTypes.CharType
{
  internal class CharExample
  {
    public static char letter = 'A';
    public static char digit = '5';
    public static char symbol = '@';

    public static void Run()
    {
      Console.WriteLine($"This is the char data type example: ");
      Console.WriteLine("char letter = 'A';");
      Console.WriteLine("char digit = '5';");
      Console.WriteLine("char symbol = '@';");
      Console.WriteLine($"The variable letter is type {letter.GetType()} and has a value of '{letter}'");
      Console.WriteLine($"The variable digit is type {digit.GetType()} and has a value of '{digit}'");
      Console.WriteLine($"The variable symbol is type {symbol.GetType()} and has a value of '{symbol}'");
      Console.WriteLine();

      // Demonstrating Unicode values
      Console.WriteLine("Unicode Values:");
      Console.WriteLine($"'{letter}' has Unicode value: {(int)letter}");
      Console.WriteLine($"'{digit}' has Unicode value: {(int)digit}");
      Console.WriteLine($"'{symbol}' has Unicode value: {(int)symbol}");
      Console.WriteLine();

      // Demonstrating char methods
      Console.WriteLine("Character Methods:");
      Console.WriteLine($"char.IsLetter('{letter}'): {char.IsLetter(letter)}");
      Console.WriteLine($"char.IsDigit('{digit}'): {char.IsDigit(digit)}");
      Console.WriteLine($"char.IsSymbol('{symbol}'): {char.IsSymbol(symbol)}");
      Console.WriteLine($"char.IsUpper('{letter}'): {char.IsUpper(letter)}");
      Console.WriteLine($"char.ToLower('{letter}'): '{char.ToLower(letter)}'");
      Console.WriteLine();

      // Demonstrating escape sequences
      Console.WriteLine("Escape Sequences:");
      char newline = '\n';
      char tab = '\t';
      char backslash = '\\';
      char quote = '\'';

      Console.WriteLine($"Newline: '\\n' = ASCII {(int)newline}");
      Console.WriteLine($"Tab: '\\t' = ASCII {(int)tab}");
      Console.WriteLine($"Backslash: '\\\\' = ASCII {(int)backslash}");
      Console.WriteLine($"Single Quote: '\\'' = ASCII {(int)quote}");
      Console.WriteLine();

      // Demonstrating char arithmetic
      Console.WriteLine("Character Arithmetic:");
      char startChar = 'A';
      char nextChar = (char)(startChar + 1);
      Console.WriteLine($"'{startChar}' + 1 = '{nextChar}'");

      for (int i = 0; i < 5; i++)
      {
        char currentChar = (char)('A' + i);
        Console.WriteLine($"Alphabet position {i}: '{currentChar}'");
      }
      Console.WriteLine();
    }
  }
}