// DateTime, DateOnly, TimeOnly:
// use DateTime for date and time, DateOnly for dates, TimeOnly for times
// DateTime: 8 bytes (64 bits), represents dates from 1/1/0001 to 12/31/9999
// DateOnly: 4 bytes (32 bits), represents dates only (.NET 6+)
// TimeOnly: 8 bytes (64 bits), represents time of day only (.NET 6+)

// TYPE:
// built-in value types (structs)

// SYNTAX:
// DateTime dateTime = DateTime.Now;
// DateOnly date = DateOnly.FromDateTime(DateTime.Now);
// TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);

// RETURNS:
// date and/or time values with various precision levels

// USES:
// date/time calculations, scheduling, logging, data storage with temporal requirements

namespace CSharpNotes.DataTypes.ValueTypes.DateTimeTypes
{
  internal class DateTimeExample
  {
    public static DateTime currentDateTime = DateTime.Now;
    public static DateTime specificDate = new DateTime(2024, 12, 25, 14, 30, 0);
    public static DateOnly today = DateOnly.FromDateTime(DateTime.Now);
    public static TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);

    public static void Run()
    {
      Console.WriteLine($"This is the DateTime types example: ");
      Console.WriteLine("DateTime currentDateTime = DateTime.Now;");
      Console.WriteLine("DateTime specificDate = new DateTime(2024, 12, 25, 14, 30, 0);");
      Console.WriteLine("DateOnly today = DateOnly.FromDateTime(DateTime.Now);");
      Console.WriteLine("TimeOnly currentTime = TimeOnly.FromDateTime(DateTime.Now);");
      Console.WriteLine($"The variable currentDateTime is type {currentDateTime.GetType()} and has a value of {currentDateTime}");
      Console.WriteLine($"The variable specificDate is type {specificDate.GetType()} and has a value of {specificDate}");
      Console.WriteLine($"The variable today is type {today.GetType()} and has a value of {today}");
      Console.WriteLine($"The variable currentTime is type {currentTime.GetType()} and has a value of {currentTime}");
      Console.WriteLine();

      // Demonstrating DateTime creation methods
      Console.WriteLine("DateTime Creation Methods:");
      DateTime now = DateTime.Now;                    // Local current date/time
      DateTime utcNow = DateTime.UtcNow;             // UTC current date/time
      DateTime parsedDate = DateTime.Parse("2024-01-15 10:30:00");
      DateTime.TryParse("2024-02-29", out DateTime leapYear);

      Console.WriteLine($"DateTime.Now: {now}");
      Console.WriteLine($"DateTime.UtcNow: {utcNow}");
      Console.WriteLine($"Parsed date: {parsedDate}");
      Console.WriteLine($"Leap year date: {leapYear}");
      Console.WriteLine();

      // Demonstrating DateTime properties
      Console.WriteLine("DateTime Properties:");
      DateTime sample = new DateTime(2024, 7, 4, 15, 30, 45);
      Console.WriteLine($"Sample DateTime: {sample}");
      Console.WriteLine($"Year: {sample.Year}");
      Console.WriteLine($"Month: {sample.Month}");
      Console.WriteLine($"Day: {sample.Day}");
      Console.WriteLine($"Hour: {sample.Hour}");
      Console.WriteLine($"Minute: {sample.Minute}");
      Console.WriteLine($"Second: {sample.Second}");
      Console.WriteLine($"DayOfWeek: {sample.DayOfWeek}");
      Console.WriteLine($"DayOfYear: {sample.DayOfYear}");
      Console.WriteLine();

      // Demonstrating DateTime arithmetic
      Console.WriteLine("DateTime Arithmetic:");
      DateTime baseDate = new DateTime(2024, 1, 1);
      DateTime futureDate = baseDate.AddDays(30).AddHours(12).AddMinutes(30);
      TimeSpan difference = futureDate - baseDate;

      Console.WriteLine($"Base date: {baseDate}");
      Console.WriteLine($"Future date: {futureDate}");
      Console.WriteLine($"Difference: {difference}");
      Console.WriteLine($"Days difference: {difference.TotalDays:F2}");
      Console.WriteLine();

      // Demonstrating DateTime formatting
      Console.WriteLine("DateTime Formatting:");
      DateTime formatExample = new DateTime(2024, 3, 15, 14, 30, 0);
      Console.WriteLine($"Default: {formatExample}");
      Console.WriteLine($"Short date: {formatExample.ToShortDateString()}");
      Console.WriteLine($"Long date: {formatExample.ToLongDateString()}");
      Console.WriteLine($"Short time: {formatExample.ToShortTimeString()}");
      Console.WriteLine($"Custom format: {formatExample.ToString("yyyy-MM-dd HH:mm:ss")}");
      Console.WriteLine($"ISO 8601: {formatExample.ToString("yyyy-MM-ddTHH:mm:ss")}");
      Console.WriteLine();

      // Demonstrating DateOnly (.NET 6+)
      Console.WriteLine("DateOnly Examples:");
      DateOnly dateOnly1 = new DateOnly(2024, 6, 15);
      DateOnly dateOnly2 = DateOnly.FromDateTime(DateTime.Now);
      DateOnly parsedDateOnly = DateOnly.Parse("2024-12-25");

      Console.WriteLine($"DateOnly constructor: {dateOnly1}");
      Console.WriteLine($"DateOnly from DateTime: {dateOnly2}");
      Console.WriteLine($"Parsed DateOnly: {parsedDateOnly}");

      // DateOnly arithmetic
      DateOnly nextWeek = dateOnly2.AddDays(7);
      DateOnly nextMonth = dateOnly2.AddMonths(1);
      int daysBetween = nextWeek.DayNumber - dateOnly2.DayNumber;

      Console.WriteLine($"Next week: {nextWeek}");
      Console.WriteLine($"Next month: {nextMonth}");
      Console.WriteLine($"Days between: {daysBetween}");
      Console.WriteLine();

      // Demonstrating TimeOnly (.NET 6+)
      Console.WriteLine("TimeOnly Examples:");
      TimeOnly timeOnly1 = new TimeOnly(14, 30, 0);  // 2:30 PM
      TimeOnly timeOnly2 = TimeOnly.FromDateTime(DateTime.Now);
      TimeOnly parsedTime = TimeOnly.Parse("09:15:30");

      Console.WriteLine($"TimeOnly constructor: {timeOnly1}");
      Console.WriteLine($"TimeOnly from DateTime: {timeOnly2}");
      Console.WriteLine($"Parsed TimeOnly: {parsedTime}");

      // TimeOnly arithmetic and formatting
      TimeOnly laterTime = timeOnly1.AddHours(2).AddMinutes(30);
      Console.WriteLine($"Later time: {laterTime}");
      Console.WriteLine($"12-hour format: {timeOnly1.ToString("hh:mm tt")}");
      Console.WriteLine($"24-hour format: {timeOnly1.ToString("HH:mm:ss")}");
      Console.WriteLine();

      // Demonstrating combining DateOnly and TimeOnly
      Console.WriteLine("Combining DateOnly and TimeOnly:");
      DateOnly date = new DateOnly(2024, 7, 4);
      TimeOnly time = new TimeOnly(15, 30, 0);
      DateTime combined = date.ToDateTime(time);

      Console.WriteLine($"Date: {date}");
      Console.WriteLine($"Time: {time}");
      Console.WriteLine($"Combined DateTime: {combined}");
      Console.WriteLine();

      // Demonstrating nullable DateTime types
      Console.WriteLine("Nullable DateTime Types:");
      DateTime? nullableDateTime = null;
      DateOnly? nullableDate = null;
      TimeOnly? nullableTime = null;

      Console.WriteLine($"Nullable DateTime (null): {nullableDateTime?.ToString() ?? "null"}");
      Console.WriteLine($"Nullable DateOnly (null): {nullableDate?.ToString() ?? "null"}");
      Console.WriteLine($"Nullable TimeOnly (null): {nullableTime?.ToString() ?? "null"}");

      nullableDateTime = DateTime.Now;
      Console.WriteLine($"Nullable DateTime (has value): {nullableDateTime}");
      Console.WriteLine();
    }
  }
}