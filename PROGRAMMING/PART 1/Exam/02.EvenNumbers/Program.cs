/*Задача 2
Напишете програма която подканва потребителя да въведе три цели положителни числа M, N и K , 
 * където M < N и отпечатва всички четни числа в интервала [M, N] които се делят точно на K (всяко на нов ред) 
 * и тяхната сума на последния ред.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberM, numberN, numberK;
            string input;
            int sum = 0;

            do
            {
                Console.Write("Въведете число M: ");
                input = Console.ReadLine();
            }
            while (!(int.TryParse(input, out numberM) && (numberM >= 0)));

            do
            {
                Console.Write("Въведете число N: ");
                input = Console.ReadLine();
            }
            while (!(int.TryParse(input, out numberN) && (numberN > numberM)));

            do
            {
                Console.Write("Въведете число K: ");
                input = Console.ReadLine();
            }
            while (!(int.TryParse(input, out numberK) && (numberK > 0)));

            Console.WriteLine("всички четни числа в интервала [M, N] които се делят точно на K :");
            for (int i = numberM; i <= numberN; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % numberK == 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                }
            }
            Console.WriteLine("sum: {0}", sum);
        }
    }
}
