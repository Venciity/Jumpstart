using System;

class ReadingNumbers
{
    static void Main()
    {
        Console.Write("Write a number: ");
        string str = Console.ReadLine();
        int number = Int32.Parse(str);
        //the same as
        //int number = int.Parse(str);
        number++;
        Console.WriteLine("Your number + 1 = {0}", number);


        Console.Write("a = ");
        string line = Console.ReadLine();
        int a = Int32.Parse(line);

        Console.Write("b = ");
        line = Console.ReadLine();
        int b = Int32.Parse(line);

        Console.WriteLine("{0} + {1} = {2}",
			a, b, a + b);
        Console.WriteLine("{0} * {1} = {2}",
			a, b, a * b);

        Console.Write("f = ");
        line = Console.ReadLine();
        float f = Single.Parse(line);
        Console.WriteLine("{0} * {1} / {2} = {3}",
			a, b, f, a * b / f);
    }
}
