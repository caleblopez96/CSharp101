// enum:
// user-defined type representing a set of name constants

// TYPE:
// user-defined value type (primitive)

// SYNTAX:
// enum EnumName { Value1, Value2, Value3 };

// RETURNS:
// an enum value

// USES:
// representing a fixed set of related name values (like days, states, categories)

namespace CSharpNotes.DataTypes.ValueTypes.Other
{
    internal class EnumExample
    {
        public enum Day { Sunday, Monday, Tuesday }
        public static Day today = Day.Monday;
        public static Day yesterday = Day.Sunday;

        public static void Run()
        {
            Console.WriteLine($"This is the enum data type example: ");
            Console.WriteLine("enum Day { Sunday, Monday, Tuesday };");
            Console.WriteLine("Day today = Day.Monday;");
            Console.WriteLine("Day yesterday = Day.Sunday");
            Console.WriteLine($"The variable today and yesterday is type {today.GetType()}");
            Console.WriteLine($"The variable today has a value of: {today}");
            Console.WriteLine($"The variable yesterday has a value of: {yesterday}");
            Console.WriteLine();
        }
    }
}
