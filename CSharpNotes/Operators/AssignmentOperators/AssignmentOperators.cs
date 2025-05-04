// Assignment Operators:
// operators that assign values to variables, optionally combining them with arithmetic or other operators

// KEY CONCEPTS:
// - Used to assign or update the value of a variable
// - Can combine arithmetic operators for shorthand operations

// OPERATORS:
// = -> assignment operator
// += -> add and assign
// -= -> subtract and assign
// *= -> multiply and assign
// /= -> divide and assign
// %= -> modulus and assign

// SYNTAX:
// int x = 5 -> assign 5 to x
// x += 3 -> x = x + 3 (x is 8)
// x -= 2 -> x = x - 2 (x us 6)
// x *= 4 -> x = x * 4 (x is 24)
// x /= 6 -> x = x / 6 (x is 4)
// x %= 3 -> x = x % 3 (x is 1)


namespace CSharpNotes.Operators.AssignmentOperators
{
    internal class AssignmentOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is the assingment operator examples.");

            int value = 10;
            Console.WriteLine($"Intital value: {value}");

            value += 5;
            Console.WriteLine($"Value after += 5: {value}"); // 15

            value -= 2;
            Console.WriteLine($"Value after -= 2: {value}"); // 13

            value *= 2;
            Console.WriteLine($"Value after *= 2: {value}"); // 26

            value /= 2;
            Console.WriteLine($"Value after /= 2: {value}"); // 13

            value %= 2;
            Console.WriteLine($"Value after %= 2: {value}"); // 1
        }
    }
}
