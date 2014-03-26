/*Напишете метод, който връща индекса на първия елемент в масив стойноста на който е по-голяма
 * от тази на съседите му, или -1 ако такъв елемент не съществува.
 * Използвайте метода от предходната задача.    */
using System;

    class FirstNeighbours
    {
        static bool IsBiggerThanNeighbours(int index, int[] numbers)
        {
            if (index == 0 || index == numbers.Length - 1)
            {
                return false;
            }
            if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
            {
                return true;
            }
            return false;
        }

        static int GetFirstIndex(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (IsBiggerThanNeighbours(i, numbers))
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            int[] myNumbers = { 3, 2, 11, 10, 43, 42, 6 };

            Console.WriteLine(GetFirstIndex(myNumbers));
        }
    }