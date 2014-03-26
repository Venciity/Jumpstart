/*Напишете метод, който връща последната цифра на дадено число като английска дума.
 * Например: 512 -> "two" 1024 -> "four" 12309 -> "nine"    */
using System;

    class EnglishWord
    {
        static string GetLastDigitAsText(int number)
        {
            if (number < 0)
            {
                number = -number; // за работа с отрицателни числа
            }

            int digit = number % 10;
            string[] digitAsString = 
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven","eight", "nine"
            };

            return digitAsString[digit];
        }
        static void Main()
        {
            Console.Write("Number = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsText(n));
        }
    }