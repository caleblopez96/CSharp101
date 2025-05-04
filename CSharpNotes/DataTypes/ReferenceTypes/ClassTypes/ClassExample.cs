// class:
// use the class keyword to declare a class
// a class is a blueprint for creating objects (instances)

// TYPE:
// user-defined reference type

// SYNTAX:
// class className { public int Property; }

// RETURNS:
// an instance of the class

// USES:
// defining complex data models with properties and methods

namespace CSharpNotes.DataTypes.ReferenceTypes.ClassTypes
{
    internal class ClassExample
    {
        public class Car
        {
            public string Model = "";
            public int Year;
        }

        public static void Run()
        {
            Car myCar = new()
            {
                Model = "Civic",
                Year = 2018
            };

            Console.WriteLine($"This is the class data type example: ");
            Console.WriteLine("class Car {}");
            Console.WriteLine($"The variable myCar is an instace of Car");
            Console.Write($"My cars model is: {myCar.Model}");
            Console.WriteLine($"My cars year is: {myCar.Year}");
            Console.WriteLine();
        }
    }
}
