// action:
// a delegate type for a method that returns void

// TYPE:
// built-in reference type

// SYNTAX:
// action actionName = methodName;

// RETURNS:
// No value (void)

// USES:
// pointing to and invoking methods that don't return a value
namespace CSharpNotes.DataTypes.ReferenceTypes.DelegateTypes
{
    internal class ActionExample
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello from an action delegate");
        }

        public static void Run()
        {
            Console.WriteLine("This is the Action delegate example:");
            Action greet = SayHello;
            greet();
            Console.WriteLine();
        }
    }
}
