/*Напишете метод, който брои колко пъти дадено число се среща в даден масив.
 * Напишете тестова програма която проверява дали метода работи коректно.*/
using System;

    class CountNumberInArray
    {
        static int CountOccurences(int number, int[] numbers)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == number)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main()
        {
            Console.Write("Number = ");
            int n = Int32.Parse(Console.ReadLine());

            int[] myNumbers = { 3, 6, 1, 10, 43, 42, 6 };
            int count = CountOccurences(n, myNumbers);
            Console.WriteLine("count = {0}",count);
        }
    }