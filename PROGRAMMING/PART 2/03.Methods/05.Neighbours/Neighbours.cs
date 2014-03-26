/*Напишете метод, който проверява дали елемент на определена позиция в даден масив от цели числа
 * е по-голям от двата си съседа (ако такива съществуват).
 * Когато елемента има един или нула на брой съседи, метода връща false.*/
using System;

    class Neighbours
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
        static void Main()
        {
            Console.Write("Number = ");
            int n = Int32.Parse(Console.ReadLine());

            int[] myNumbers = { 3, 6, 1, 10, 43, 42, 6 };

            Console.WriteLine(IsBiggerThanNeighbours(n, myNumbers));
        }
    }