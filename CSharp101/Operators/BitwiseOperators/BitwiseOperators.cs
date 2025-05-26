// Bitwise Operators:
// operators that perform operations directly on the binary (bit) representations of integers.

// KEY CONCEPTS:
// - work at the bit level of integer types (int, byte, etc.)
// - useful for low-level programming, flags, permissions, and optimizations

// OPERATORS:
// &   → Bitwise AND  
// |   → Bitwise OR  
// ^   → Bitwise XOR (exclusive OR)  
// ~   → Bitwise NOT (inverts all bits)  
// <<  → Left shift (moves bits left, adds zeroes on the right)  
// >>  → Right shift (moves bits right, preserves sign bit)

// SYNTAX EXAMPLES:
// int a = 5;       // 0101 in binary
// int b = 3;       // 0011 in binary

// int andResult = a & b;  // 0001 (1)
// int orResult = a | b;   // 0111 (7)
// int xorResult = a ^ b;  // 0110 (6)
// int notResult = ~a;     // 1010... (inverts all bits)
// int leftShift = a << 1; // 1010 (10)
// int rightShift = a >> 1;// 0010 (2)

// USE CASES:
// - working with flags and permissions (on/off states)
// - low-level graphics or hardware programming
// - performance-sensitive applications involving binary math

// NOTES:
// - operates on the individual bits of integer values
// - not commonly used in high-level business logic but critical in systems-level code

namespace CSharpNotes.Operators.BitwiseOperators
{
    internal class BitwiseOperatorsExample
    {
        public static void Run()
        {
            Console.WriteLine("This is the bitwise operators example.");

            int a = 5;  // 0101
            int b = 3;  // 0011

            Console.WriteLine($"a & b: {a & b}");      // 0001 → 1
            Console.WriteLine($"a | b: {a | b}");      // 0111 → 7
            Console.WriteLine($"a ^ b: {a ^ b}");      // 0110 → 6
            Console.WriteLine($"~a: {~a}");            // 1111...1010 → -6 (2's complement)
            Console.WriteLine($"a << 1: {a << 1}");    // 1010 → 10
            Console.WriteLine($"a >> 1: {a >> 1}");    // 0010 → 2

            Console.WriteLine();
        }
    }
}
