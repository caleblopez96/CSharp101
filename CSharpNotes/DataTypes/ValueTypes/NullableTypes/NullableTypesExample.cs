// nullable types:
// any value type can be made nullable by adding ?

// TYPE:
// struct (value type with a nullable wrapper)

// SYNTAX:
// int? variableName = null;
// double? temperature = null;
// bool? isValid = null;

// RETURNS:
// a value or null

// USES:
// representing optional numbers (age, score, etc...) where value may be undefined or missing

namespace CSharpNotes.DataTypes.ValueTypes.NullableTypes
{
    internal class NullableTypesExample
    {
        public static int? age = null;
        public static double? temperature2 = null;
        public static bool? isValid = null;

        public static void Run()
        {
            Console.WriteLine("This is the nullable types example");
            Console.WriteLine("Any value type can be made nullable with a ?");
            Console.WriteLine("int? age = null");
            Console.WriteLine("double? temperature2 = null;");
            Console.WriteLine("bool? isValid = null;");
        }
    }
}
