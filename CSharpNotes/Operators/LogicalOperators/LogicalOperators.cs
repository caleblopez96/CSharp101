// Logical Operators: 
// Operators that combine multiple boolean expressions and returns a bool result

// KEY CONCEPTS:
// work with expressions that return bool values
// used to create complex conditional logic
// often used in if, while and for statements

// OPERATORS:
// && -> logical AND (all conditons must be true)
// || -> logical OR (at least one condition needs to be true)
// ! -> logical NOT (inverts the boolean value)

// EXAMPLES:
// (5 > 3) && (10 > 5) true
// (5 > 3) || (10 > 5) true
// !(5 == 5) false

namespace CSharpNotes.Operators.LogicalOperators
{
    internal class LogicalOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is the Logical Operator example");

            // and
            Console.WriteLine($"AND: (5 > 3) && (5 > 10) = {(5 > 3) && (5 > 10)}"); // true
            
            // or
            Console.WriteLine($"OR: (5 < 3) || (10 > 5) = {(5 < 3) || (10 > 5)}"); // true

            // not
            Console.WriteLine($"NOT: !(5 == 5) = {!(5 == 5)}"); // false

            Console.WriteLine();
        }
    }
}
