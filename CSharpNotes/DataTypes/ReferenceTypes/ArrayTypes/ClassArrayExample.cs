// class[]:
// array of custom class objects

// TYPE:
// user-defined reference type

// SYNTAX:
// MyClass[] instances = new MyClass[] { new myClass(), new MyClass() };
// 
// MyClass[] instances = [new MyClass(), new MyClass()];

// RETURNS:
// an array of custom class instances

// USES:
// storing multiple objects with shared structure and behavior

using System.Xml.Serialization;

namespace CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes
{
    internal class ClassArrayExample
    {
        public class Person
        {
            public string Name = "";
        }

        public static Person[] people = new Person[]
        {
            new() { Name = "Walter"},
            new() { Name = "Jesse"}
        };

        public static void Run()
        {
            Console.WriteLine($"This is the class array data type example: ");
            Console.WriteLine("MyClass instances = [ new myClass(), new MyClass() ];");
            Console.WriteLine($"The variable people is type {people.GetType()}");
            Console.WriteLine("Values:");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }
}
