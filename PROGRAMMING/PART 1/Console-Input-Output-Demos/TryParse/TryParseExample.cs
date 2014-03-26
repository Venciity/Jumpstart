using System;

class TryParseExample
{
    static void Main()
    {
        Console.Write("Insert a number: ");
        string str = Console.ReadLine();
        int number;
        if (int.TryParse(str, out number))
        {
            Console.WriteLine("Valid number: {0}", number);
        }
        else
        {
            Console.WriteLine("Invalid number: {0}", str);
        }
    }
}
