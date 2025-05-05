// Unary Operators:
// Operators that operate on a single operand to produce a new value.

// KEY CONCEPTS:
// - works on one operand only
// - can be used to modify, test, or return a new value from a single value
// - common in arithmetic, logical, and increment/decrement operations

// OPERATORS:
// +   → Unary plus (typically redundant, indicates positive value)
// -   → Unary minus (negates a value)
// ++  → Increment (increases value by 1)
// --  → Decrement (decreases value by 1)
// !   → Logical NOT (inverts a boolean value)
// ~   → Bitwise NOT (inverts all bits in an integer)

// SYNTAX EXAMPLES:
// int a = 5;
// int b = -a; -> -5
// a++; -> 6
// a--; -> 5
// bool isTrue = false; -> false
// bool notTrue = !isTrue; -> true

// USE CASES:
// - quickly incrementing or decrementing numeric values
// - toggling boolean states
// - working with signs of numbers or inverting bit patterns

// NOTES:
// - ++ and -- can be used as prefix (++a) or postfix (a++) with slight behavioral differences
// - prefix: modifies before use in an expression
// - postfix: modifies after use in an expression

namespace CSharpNotes.Operators.UnaryOperators
{
    internal class UnaryOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is the unary operators example.");

            int a = 5;
            Console.WriteLine($"+a: {+a}");
            Console.WriteLine($"-a: {-a}");

            a++;
            Console.WriteLine($"a++: {a}");

            a--;
            Console.WriteLine($"a--: {a}");

            bool isTrue = false;
            Console.WriteLine($"!isTrue: {!isTrue}");

            int b = 5;
            Console.WriteLine($"~b: {~b}");

            Console.WriteLine();
        }
    }
}
