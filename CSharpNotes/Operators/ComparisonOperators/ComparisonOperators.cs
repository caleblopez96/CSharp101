// Comparison Operators:
// compare two values that return a boolean

// KEY CONCEPTS:
// compare numeric, string, or other comparable values
// returns a boolean
// commonly used in conditionals

// OPERATORS:
// == equal to
// != not equal to
// > greater than
// < less than
// >= greater than or equal to 
// <= less than or equal to

// EXAMPLES:
// bool isEqual = (5 == 5); true
// bool isNotEqual = (10 != 5) true
// bool isGreater = (5 > 10) false
// bool isLess = (10 < 5) true
// bool isGreaterOrEqual = (10 >= 5) true
// bool isLessOrEqual = (5 <= 10) true

namespace CSharpNotes.Operators.ComparisonOperators
{
    internal class ComparisonOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is the comparison operator example");
            Console.WriteLine($"Equals: 5 == 5 = {5 == 5}"); // true
            Console.WriteLine($"Not Equal: 10 != 5 = {10 != 5}"); // true
            Console.WriteLine($"Is Greater: 5 > 10 = {5 > 10}"); // false
            Console.WriteLine($"Is Less: 5 < 10 = {5 < 10}"); // true 
            Console.WriteLine($"Greater or Equal to: 5 >= 10 = {5 >= 10}"); // false
            Console.WriteLine($"Less or Equal to: 10 <= 5 = {10 <= 5}"); // false
        }
    }
}
