/*Напишете методи за изчисляване на мин, макс, средна стойност, сума и произведение
 * на дадено множество от цели числа. Нека методите бъдат с променлив брой аргументи.   */
using System;

    class MinMaxAverageSumAndProduct
    {
        static int Min(params int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int Max(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static long Sum(params int[] numbers)
        {
            long sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        static decimal Averge(params int[] numbers)
        {
            return Sum(numbers) / (decimal) numbers.Length;
        }

        static long Product(params int[] numbers)
        {
            long product = 1;
            foreach (var n in numbers)
            {
                product *= n;
            }
            return product;
        }

        static void Main()
        {
            int[] numbers = { 23, 6, 55, 1, 5, 3, 7, 1 };

            Console.WriteLine(Min(23, 6, 55, 1, 5, 3, 7, 1));
            Console.WriteLine(Max(4, 7, 89, 234, 6, 100, 1));
            Console.WriteLine(Averge(3, 2, 1, 54, 12));
            Console.WriteLine(Sum(3, 2, 1, 54, 12));
            Console.WriteLine(Product(3, 2, 1, 54, 12, 1, 1, 1, 1));
        }
    }