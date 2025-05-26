// Arithmetic Operators:
// Operators that perform basic mathematical operations on numeric values

// KEY CONCEPTS:
// - Work with numeric types (int, double, float, etc...)
// - Return a value based on the operation performed

// OPERATORS:
// + -> Addition
// - -> Subtraction
// * -> Multiplication
// / -> Division
// % -> Modulos (remainder)

// SYNTAX EXAMPLES:
// int sum = 5 + 3;
// int difference = 10 - 4;
// int product = 2 * 2;
// double quotient = 10.0 / 3.0
// int remainder = 10 % 3

// NOTES:
// Division between two integers truncates decimal results (use double/float for precise division)
// Modulos returns the remainder after division

namespace CSharpNotes.Operators.ArithmeticOperators
{
    internal class ArithmeticOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is the arithmetic operators example");
            int a = 10, b = 20;

            int sum = a + b; // 30
            int difference = a - b; // -10
            int product = a * b; // 200
            double quotient = (double) a / b; // 0.5
            int remainder = a % b; // 10

            // addition
            Console.WriteLine($"Addition: { a } + { b } = { sum }");

            // subtraction
            Console.WriteLine($"Subtraction: { a } - { b } = { difference }");

            // multiplication
            Console.WriteLine($"Product: { a } * { b } = { product }");

            // division
            Console.WriteLine($"Quotient: { a } / { b } = { quotient }");

            // modulo
            Console.WriteLine($"Remainder: { a } % { b } = {remainder}");
            
            Console.WriteLine();
        }
    }
}
