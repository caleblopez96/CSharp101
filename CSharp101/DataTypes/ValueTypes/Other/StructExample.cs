// struct:
// use the struct keyword to declare a struct

// TYPE:
// user-defined value type (primitive)

// SYNTAX:
// struct StructName { public int x; public int y; }

// RETURNS:
// an instance of the struct

// USES:
// grouping related small data together without creating a full class

namespace CSharpNotes.DataTypes.ValueTypes.Other
{
    internal class StructExample
    {
        public struct Point
        {
            public int x;
            public int y;
        }

        public static void Run()
        {
            Point p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine($"This is the stuct data type example: ");
            Console.WriteLine("struct Point { public int x; public int y; }");
            Console.WriteLine($"Point p = (X: { p.x }, Y: { p.y })");
            Console.WriteLine();
        }
    }
}
