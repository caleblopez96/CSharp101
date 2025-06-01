// Object Instantiation:
// the process of creating an actual object (instance) from a class

// SYNTAX EXAMPLE:
// ClassName variableName = new ClassName()
// OR
// ClassName variableName = new();

// USES:
// creating usable objects from a class
// storing different sets of data in multiple objects from the same class definition

namespace CSharpNotes.Classes
{
  public class ObjectInstantiation
  {
    public class Car
    {
      // property with get and set
      public string Brand { get; set; }

      // property with get and set
      public int Year { get; set; }

      // method
      public void Honk()
      {
        Console.WriteLine("BEEP BEEP");
      }
    }

    public static void Run()
    {
      Console.WriteLine("This is the object instantiation example with properties only.");

      // create (instantiate) a new car object
      Car myCar = new()
      {
        Brand = "Honda",
        Year = 2018
      };

      Console.WriteLine($"Brand: {myCar.Brand}, Year: {myCar.Year}");

      myCar.Honk();
    }
  }
}
