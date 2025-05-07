// Inheritance:
// allows a class (derived/child class) to inherit members (fields, properties, and methods) from another class (base/parent class)

// SYNTAX:
/* 

Base class:
public class ParentClass
{
  public string Property {get; set;}

  public void MethodName()
  {
    Console.WriteLine("This is a method fro the parent class")
  }
}

Derived class:
public class DerivedClass : ParentClass
{
  public void MethodName()
  {
    Console.WriteLine("This is a Method from teh derived class)
  }
}

*/
namespace CSharpNotes.Methods
{
  public class InheritanceExample
  {
    // base class 
    public class Animal
    {
      public string Name { get; set; }

      public virtual void Speak()
      {
        Console.WriteLine("This animal speaks");
      }
    }
    // derived class
    public class Dog : Animal
    {
      public override void Speak()
      {
        Console.WriteLine("This dog barks");
      }
    }

    // another derived class
    public class Cat : Animal
    {
      public override void Speak()
      {
        Console.WriteLine("This cat meows");
      }
    }
    public static void Run()
    {
      Console.WriteLine("This is the inheritance example");

      // instatiate object from parent class
      Animal genericAnimal = new()
      {
        Name = "Generic Animal"
      };
      genericAnimal.Speak();

      // instatiate object derived from parent class
      Dog myDog = new()
      {
        Name = "b's"
      };
      myDog.Speak();

      // instatiate object derived from parent class
      Cat myCat = new()
      {
        Name = "Garfield"
      };
      myCat.Speak();

      Console.WriteLine();
    }
  }
}