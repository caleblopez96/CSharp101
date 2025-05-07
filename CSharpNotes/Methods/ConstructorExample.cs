// Constructors:
// a constructor is a special method that runs when an object is created. 
// It initializes the object's state (fields/properties)

// SYNTAX:
/* 
parameterless constructor:

public ClassName()
{
  initialization code
}
use it:
Car defaultCar = new();

---------------------------------------------------------------------
constructor with parameters:

public ClassName(string param1, int param2)
{
  initialization code using params
}
use it:
Car civic = new("Honda", "Civic", 2018);

---------------------------------------------------------------------
object initializer (alternative to setting properties after construction):

ClassName obj = new() 
{
  Property1 = "value",
  Property2 = 123
}

use it:
Car corolla = new()
  {
    Make = "Toyota",
    Model = "Corolla"
    year can’t be set here because its setter is private
  };
*/

// USES:
// constructors set up initial values for an object's fields/properties when it's created.
// you can control how an object should be initialized when it’s made.

namespace CSharpNotes.Methods
{
  public class ConstructorExample
  {
    public class Car
    {
      // auto-implemented properties
      public string Make { get; set; }
      public string Model { get; set; }
      public int Year { get; private set; } // private set example

      // parameterless constructor
      public Car()
      {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
      }

      // constructor with parameters
      public Car(string make, string model, int year)
      {
        Make = make;
        Model = model;
        Year = year;
      }

      // instance method to display car info
      public void DisplayInfo()
      {
        Console.WriteLine($"Car: {Make} {Model}, Year: {Year}");
        Console.WriteLine();
      }
    }

    public static void Run()
    {
      Console.WriteLine("=== Parameterless Constructor ===");
      Car defaultCar = new();
      defaultCar.DisplayInfo();

      Console.WriteLine("=== Constructor with Parameters ===");
      Car civic = new("Honda", "Civic", 2018);
      civic.DisplayInfo();

      Console.WriteLine("=== Object Initializer ===");
      Car corolla = new()
      {
        Make = "Toyota",
        Model = "Corolla"
        // year can’t be set here because its setter is private
      };
      corolla.DisplayInfo();

      Console.WriteLine();
    }
  }
}
