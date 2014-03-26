using System;
using System.Text;

class ReadingStrings
{
    static void Main()
    {
        //if Unicode is not specified , it will read ASCII
        //Works on .NET Framework 4.0 and above
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Hello, {0} {1} !", firstName, lastName);
    }
}
