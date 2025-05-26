// struct:
// use the struct keyword to declare a structure type
// represents a value type that can encapsulate data and related functionality
// allocated on the stack, copied by value

// TYPE:
// user-defined value type

// SYNTAX:
// struct StructName { fields, properties, methods }

// RETURNS:
// a value type with encapsulated data and behavior

// USES:
// lightweight objects, immutable data, performance-critical scenarios, small data collections

namespace CSharpNotes.DataTypes.ValueTypes.StructTypes
{
  // Basic struct declaration
  public struct Point
  {
    public int X;
    public int Y;

    // Constructor
    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    // Method
    public double DistanceFromOrigin()
    {
      return Math.Sqrt(X * X + Y * Y);
    }

    // Override ToString
    public override string ToString()
    {
      return $"({X}, {Y})";
    }
  }

  // Struct with properties
  public struct Rectangle
  {
    private int _width;
    private int _height;

    public int Width
    {
      get { return _width; }
      set { _width = value > 0 ? value : 0; }
    }

    public int Height
    {
      get { return _height; }
      set { _height = value > 0 ? value : 0; }
    }

    public Rectangle(int width, int height)
    {
      _width = width > 0 ? width : 0;
      _height = height > 0 ? height : 0;
    }

    public int Area => Width * Height;
    public int Perimeter => 2 * (Width + Height);

    public override string ToString()
    {
      return $"Rectangle: {Width}x{Height}, Area: {Area}";
    }
  }

  // Readonly struct (immutable)
  public readonly struct Color
  {
    public readonly byte Red;
    public readonly byte Green;
    public readonly byte Blue;

    public Color(byte red, byte green, byte blue)
    {
      Red = red;
      Green = green;
      Blue = blue;
    }

    public override string ToString()
    {
      return $"RGB({Red}, {Green}, {Blue})";
    }
  }

  internal class StructExample
  {
    public static Point origin = new Point(0, 0);
    public static Rectangle room = new Rectangle(10, 15);
    public static Color redColor = new Color(255, 0, 0);

    public static void Run()
    {
      Console.WriteLine($"This is the struct data type example: ");
      Console.WriteLine("Point origin = new Point(0, 0);");
      Console.WriteLine("Rectangle room = new Rectangle(10, 15);");
      Console.WriteLine("Color redColor = new Color(255, 0, 0);");
      Console.WriteLine($"The variable origin is type {origin.GetType()} and has a value of {origin}");
      Console.WriteLine($"The variable room is type {room.GetType()} and has a value of {room}");
      Console.WriteLine($"The variable redColor is type {redColor.GetType()} and has a value of {redColor}");
      Console.WriteLine();

      // Demonstrating struct methods and properties
      Console.WriteLine("Struct Methods and Properties:");
      Point p1 = new Point(3, 4);
      Console.WriteLine($"Point p1 = {p1}");
      Console.WriteLine($"Distance from origin: {p1.DistanceFromOrigin():F2}");
      Console.WriteLine($"Room area: {room.Area}");
      Console.WriteLine($"Room perimeter: {room.Perimeter}");
      Console.WriteLine();

      // Demonstrating value semantics (copying)
      Console.WriteLine("Value Semantics (Copying):");
      Point p2 = p1;  // Copy, not reference
      p2.X = 10;
      p2.Y = 20;

      Console.WriteLine($"Original p1: {p1}");
      Console.WriteLine($"Modified p2: {p2}");
      Console.WriteLine("Modifying p2 doesn't affect p1 (value type behavior)");
      Console.WriteLine();

      // Demonstrating default values
      Console.WriteLine("Default Values:");
      Point defaultPoint = new Point();  // All fields set to default values
      Rectangle defaultRect = default(Rectangle);

      Console.WriteLine($"Default Point: {defaultPoint}");
      Console.WriteLine($"Default Rectangle: {defaultRect}");
      Console.WriteLine();

      // Demonstrating struct vs class behavior
      Console.WriteLine("Struct vs Class Behavior:");
      Console.WriteLine("Structs:");
      Console.WriteLine("- Value types (stored on stack)");
      Console.WriteLine("- Copied by value");
      Console.WriteLine("- Cannot inherit from other structs/classes");
      Console.WriteLine("- Cannot be inherited");
      Console.WriteLine("- Automatically have parameterless constructor");
      Console.WriteLine("- Generally used for small, simple data");
      Console.WriteLine();

      // Demonstrating boxing/unboxing
      Console.WriteLine("Boxing and Unboxing:");
      Point boxedPoint = new Point(1, 2);
      object obj = boxedPoint;  // Boxing - struct to object reference
      Point unboxedPoint = (Point)obj;  // Unboxing - object reference back to struct

      Console.WriteLine($"Original: {boxedPoint}");
      Console.WriteLine($"After boxing/unboxing: {unboxedPoint}");
      Console.WriteLine();

      // Demonstrating nullable structs  
      Console.WriteLine("Nullable Structs:");
      Point? nullablePoint = null;
      Console.WriteLine($"Nullable Point (null): {nullablePoint}");

      nullablePoint = new Point(5, 5);
      Console.WriteLine($"Nullable Point (has value): {nullablePoint}");
      Console.WriteLine($"Has value: {nullablePoint.HasValue}");
      Console.WriteLine($"Value: {nullablePoint.Value}");
      Console.WriteLine();
    }
  }
}