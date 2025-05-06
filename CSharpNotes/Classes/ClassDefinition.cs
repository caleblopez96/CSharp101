// Class Definition:
// blueprint for creating objects that group related data (field/properties) and behaviors(methods)

// SYNTAX:
/* 

class ClassName 
{
  fields (variables)
  properties (something you get and set)
  methods (functions that do something with the data)
}

*/

// USES:
// - organizing related data and functionality together
// - modeling real-world objects and concepts
// reusing code by creating multiple objects from one class
namespace CSharpNotes.Classes
{
  public class ClassDefinition
  {
    // field (variable)
    public string brand;

    // property
    public int Year { get; set; }

    // method 
    public void Honk()
    {
      Console.WriteLine("BEEP BEEP");
    }

    public static void Run()
    {
      Console.WriteLine("This is the class syntax example");
      Console.WriteLine("A class is a blueprint for creating objects with fields, properties, and methods");
      Console.WriteLine();
    }
  }
}