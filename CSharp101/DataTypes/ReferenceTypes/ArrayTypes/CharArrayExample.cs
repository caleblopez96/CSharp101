

namespace CSharpNotes.DataTypes.ReferenceTypes.ArrayTypes
{
  public class CharArrayExample
  {
    public static void Run()
    {
      string message = "The quick brown fox jumped over the lazy brown dog";
      char[] charArray = message.ToCharArray();
      Array.Reverse(charArray);
      foreach (char messageChar in charArray)
      {
        Console.Write(messageChar);
      }
      Console.ReadLine();
    }
  }
}