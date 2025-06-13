// enum:
// use the enum keyword to declare an enumeration type
// represents a set of named constants (by default backed by int)
// 4 bytes in memory (32 bits) by default, can be customized

// TYPE:
// user-defined value type

// SYNTAX:
// enum EnumName { Value1, Value2, Value3 }

// RETURNS:
// a named constant from the enumeration

// USES:
// representing fixed sets of constants, improving code readability, type safety

// NOTE:
// enum values are stored as int's by default

namespace CSharp101.DataTypes.ValueTypes.EnumTypes
{
  // Basic enum declaration
  public enum DaysOfWeek
  {
    Sunday,    // 0
    Monday,    // 1
    Tuesday,   // 2
    Wednesday, // 3
    Thursday,  // 4
    Friday,    // 5
    Saturday   // 6
  }

  // Enum with explicit values
  public enum HttpStatusCode
  {
    OK = 200,
    NotFound = 404,
    InternalServerError = 500
  }

  internal class EnumExample
  {
    public static DaysOfWeek today = DaysOfWeek.Friday;
    public static HttpStatusCode status = HttpStatusCode.OK;
    public static void Run()
    {
      Console.WriteLine("DaysOfWeek today = DaysOfWeek.Friday;");
      Console.WriteLine("HttpStatusCode status = HttpStatusCode.OK;");
      Console.WriteLine($"The variable today is type {today.GetType()} and has a value of {today}");
      Console.WriteLine($"The variable status is type {status.GetType()} and has a value of {status}");
      Console.WriteLine();

      // enum values and casting
      Console.WriteLine("Enum Values and Casting:");
      Console.WriteLine($"today as integer: {(int)today}");
      Console.WriteLine($"status as integer: {(int)status}");
      Console.WriteLine();

      // enum methods
      Console.WriteLine("Enum Methods:");
      Console.WriteLine($"Enum.GetName(typeof(DaysOfWeek), 3): {Enum.GetName(typeof(DaysOfWeek), 3)}");
      Console.WriteLine($"Enum.GetNames(typeof(Priority)):");

      // enum parsing
      Console.WriteLine("Enum Parsing:");
      string dayString = "Monday";
      if (Enum.TryParse(dayString, out DaysOfWeek parsedDay))
      {
        Console.WriteLine($"Successfully parsed '{dayString}' to {parsedDay}");
      }

      DaysOfWeek convertedDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Tuesday");
      Console.WriteLine($"Converted 'Tuesday' to: {convertedDay}");
      Console.WriteLine();

      // Demonstrating switch with enums
      Console.WriteLine("Switch Statement with Enums:");
      string dayType = today switch
      {
        DaysOfWeek.Saturday or DaysOfWeek.Sunday => "Weekend",
        DaysOfWeek.Monday => "Start of work week",
        DaysOfWeek.Friday => "End of work week",
        _ => "Weekday"
      };
      Console.WriteLine($"Today ({today}) is: {dayType}");
      Console.WriteLine();
    }
  }
}