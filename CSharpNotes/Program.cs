using CSharpNotes.DataTypes.ReferenceTypes;
using CSharpNotes.DataTypes.ValueTypes.FloatingPointTypes;
using CSharpNotes.DataTypes.ValueTypes.IntegralTypes;
using CSharpNotes.DataTypes.ValueTypes.Other;
class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================");
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
        StringExample.Run();

        ArrayExample.Run();
        Console.Read();
    }
}
