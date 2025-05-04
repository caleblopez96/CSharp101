using CSharpNotes.DataTypes.ReferenceTypes;
using CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes;
using CSharpNotes.DataTypes.ReferenceTypes.ClassTypes;
using CSharpNotes.DataTypes.ReferenceTypes.DelegateTypes;
using CSharpNotes.DataTypes.ReferenceTypes.InterfaceTypes;
using CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes;
using CSharpNotes.DataTypes.ValueTypes.IntegralTypes;
using CSharpNotes.DataTypes.ValueTypes.Other;
class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================");
        Console.WriteLine();
        Console.WriteLine("Value Types: ");
        ByteExample.Run();
        CharExample.Run();
        IntExample.Run();
        LongExample.Run();
        SByteExample.Run();
        ShortExample.Run();
        UIntExample.Run();
        ULongExample.Run();
        UShortExample.Run();
        FloatExample.Run();
        DoubleExample.Run();
        DecimalExample.Run();
        BooleanExample.Run();
        EnumExample.Run();
        StructExample.Run();
        Console.WriteLine("==========================");
        Console.WriteLine();
        Console.WriteLine("Reference Types: ");
        StringExample.Run();
        ObjectExample.Run();
        ArrayExample.Run();
        DynamicExample.Run();
        ClassExample.Run();
        IntArrayExample.Run();
        StringArrayExample.Run();
        ClassArrayExample.Run();
        ActionExample.Run();
        FuncExample.Run();
        CustomDelegateExample.Run();
        IEnumerableExample.Run();
        IDisposableExample.Run();
        CustomInterfaceExample.Run();
        Console.WriteLine("==========================");
        Console.Read();
    }
}
