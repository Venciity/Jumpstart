using System;

class PrintingToConsole
{
    static void Main()
    {
        string greeting = "Hi!";
        string name = "Marry";
        int age = 18;
        Console.Write("{0} My Name is {1}.", greeting, name);
        Console.WriteLine("<-- Introduction");
        Console.Write("I am {0} years old.", age);
        Console.Write("<-- age{0}", Environment.NewLine);
        Console.Write("How old are you?");
        Console.Write("<-- Question");
        Console.WriteLine();
        Console.Write("What's your name?");
        Console.Write("<-- Another Question\r\n");//not recommended use
        Console.Write("This sentence is on a new line");

        Console.WriteLine();
        Console.WriteLine();

        double realNumber = 1.2345;
        Console.WriteLine("{0:0.000000}", realNumber);
        //1.234500
        Console.WriteLine("{0:0.000}", realNumber);
        //1.235  

        int a = 2, b = 3;
        Console.Write("{0} + {1} =", a, b);
        Console.WriteLine(" {0}", a + b);
        // 2 + 3 = 5

        Console.WriteLine("{0} * {1} = {2}",
                          a, b, a * b);
        // 2 * 3 = 6

        float pi = 3.14159206f;
        Console.WriteLine("{0:F2}", pi); // 3,14
        Console.WriteLine();

        decimal colaPrice = 1.20M;
        string cola = "Coca Cola";

        decimal fantaPrice = 1.10M;
        string fanta = "Fanta Madness";

        decimal shumenskoPrice = 2.20M;
        string shumensko = "Shhhumensko Premium";


        Console.WriteLine("Menu");
        Console.WriteLine("1. {0} - {1:C}", cola, colaPrice);
        Console.WriteLine("2. {0} - {1:C}", fanta, fantaPrice);
        Console.WriteLine("3. {0} - {1:C}", shumensko, shumenskoPrice);

        Console.WriteLine("   Refresh your day!");

		Console.WriteLine();
        Console.WriteLine("----------------------------------");
		Console.WriteLine("{0,-19} | {1,10:C} |", cola, colaPrice);
		Console.WriteLine("{0,-19} | {1,10:C} |", fanta, fantaPrice);
        Console.WriteLine("{0,-19} | {1,10:C} |", shumensko, shumenskoPrice);
		Console.WriteLine("{0,-19} | {1,10:C} |", "Cheese", 9.786);
        Console.WriteLine("----------------------------------");

		Console.WriteLine();
		Console.WriteLine("The hex value of {0} is {0:X}.", 32378);
	}
}
