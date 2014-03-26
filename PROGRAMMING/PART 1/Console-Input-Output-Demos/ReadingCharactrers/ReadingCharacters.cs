using System;
using System.Text;

class ReadingCharacters
{
    static void Main()
    {
        //if Unicode is not specified , it will read ASCII
        //Works on .NET Framework 4.0 and above
        //Console.InputEncoding = Encoding.Unicode;
        //Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Insert char: ");
		int i = Console.Read();
		char ch = (char)i;  // Cast the int value to char
		Console.WriteLine("The code of '{0}' is {1}.", ch, i);
	}
}
