// custom delegate:
// a user-defined type for referencing methods with a specific signature

// TYPE:
// user-defined reference type

// SYNTAX:
// delegate returnType DelegateName(paramType: paramName);

// RETURNS:
// dependent on delegate definition

// USES:
// pointing to methods with a custom signature

namespace CSharpNotes.DataTypes.ReferenceTypes.DelegateTypes
{
    internal class CustomDelegateExample
    {
        // define your custom delegate type
        public delegate string GreetingDelegate(string name);

        // method mathcing delegate signature
        public static string Greet(string name) => $"Hello {name}";

        public static void Run()
        {
            Console.WriteLine($"This is the custom delegate example: ");
            GreetingDelegate greet = Greet;
            string message = greet("Heisenburg");
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
