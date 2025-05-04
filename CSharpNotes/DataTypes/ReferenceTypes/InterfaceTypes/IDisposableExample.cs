// IDisposable:
// interface for releasing unmanaged resources

// TYPE:
// built-in reference type (interface)

// SYNTAX:
// class className : IDisposable

// RETURNS:
// Nothing, but provides Dispose() method

// USES:
// cleaning up resources like file streams, database connections

namespace CSharpNotes.DataTypes.ReferenceTypes.InterfaceTypes
{
    internal class IDisposableExample : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resources cleaned up via Dispose");
        }

        public static void Run()
        {
            Console.WriteLine("This is the IDisposable example");
            using (IDisposableExample example = new IDisposableExample())
            {
                Console.WriteLine("Inside using block");
            }
            Console.WriteLine();
        }
    }
}
