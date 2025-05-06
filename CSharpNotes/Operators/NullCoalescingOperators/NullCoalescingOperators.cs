// Null-Coalescing Operators:
// operators that privde a fallback value when a nullable type or reference is null

// KEY CONCEPTS:
// - handle null values safely
// - return a default or alternate value when the original is null
// - simplify null-checking code

// OPERATORS:
// ?? -> null-coalescing operator
// ??= -> null-coalescing assignment operator

// SYNTAX EXAMPLES:
// string? name = null;
// string displayName = name ?? "Guest" --> value is "Guest" because name = null

// int value = null;
// int finalValue = value ?? 0; --> finalValue is 0 becuase value = null

// string? username = null;
// username ??= "anonymous"; username gets set to anonymous

// USE CASES:
// providing default values for possibly null values
// avoiding NullReferenceException without verbose if-else checks
// setting fallback assignments in one line

// NOTES:
// works with nullable value types and reference types
// helps write clearner, safer, and more readable null-handling code


namespace CSharpNotes.Operators.NullCoalescingOperators
{
    internal class NullCoalescingOperators
    {
        public static void Run()
        {
            Console.WriteLine("This is null-coalescing operators example.");

            string? name = null;
            string displayName = name ?? "Guest";
            Console.WriteLine($"displayName: {displayName}"); // Guest

            int? value = null;
            int? finalValue = value ?? 0;
            Console.WriteLine($"finalValue: {finalValue}"); // 0

            string? userName = null;
            userName ??= "Anonymous";
            Console.WriteLine($"userName: {userName}"); // Anonymous

            Console.WriteLine();
        }
    }
}
