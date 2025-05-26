// static vs instance methods
// determines whether a method belongs to the class itself or to pa specific object (instance) of the class

// KEY CONCEPTS:
// - static methods: belong to the class itself, called using class name, and can't access instance-specific data directly
// - instance methods: belongs to an object (instance) of the class, called on that object, and can access instance fields and properties
// - use 'static' for static methods

// SYNTAX:
/* 

static void StaticMethodName()
{
  method body
}

void InstanceMethodName()
{
  method body
}

*/

// EXAMPLE:
// ClassName.StaticMethodName();
// objectName.InstanceMethodName();

// USE CASES:
// - static methods: utility functions, factory methods, or logic not tied to a spcific objects state
// - instance methods: behaviors that rely on an obkects fields or properties

// NOTES:
// - static methods can only access other static members (unless passed in an instance)
// - instance methods can access both instance and static members
// - common to mark entry points (like Main) and utility methods as static
// - instance methods are created when you need access to the fields or properties of the instance. If the method doesnt use data from the object like a value or a field, the compiler will ask you to change the method to static

namespace CSharpNotes.Methods
{
  public class StaticVsInstanceMethods
  {
    public string message = "im the message variable";
    // static method example
    public static void StaticGreeting()
    {
      Console.WriteLine("Hello from a static method");
    }

    // instance method example
    public void InstanceGreeting()
    {
      Console.WriteLine("Hello from an instance method");
      Console.WriteLine($"I'm an instance method because I need to work with the message variable: {message}");
    }

    public static void Run()
    {
      Console.WriteLine("This is the static vs instance methods example");

      // calling a static method
      StaticGreeting();

      // calling an instance method
      StaticVsInstanceMethods example = new();
      example.InstanceGreeting();

      Console.WriteLine();
    }
  }
}