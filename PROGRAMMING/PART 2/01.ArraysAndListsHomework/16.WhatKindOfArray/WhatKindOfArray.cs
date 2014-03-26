/*Задача М1-16.
 * Даден е числов масив. Да се провери дали той е подреден и да се от­печата един от следните резултати:
-Масивът е с равни еле­менти.
-Масивът е със строго нарастващи еле­мен­ти.
-Масивът е с нестрого нарастващи еле­мен­ти.
-Масивът е със строго намаляващи еле­мен­ти.
-Масивът е с нестрого намаляващи еле­мен­ти.
-Масивът не е подреден.     */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.WhatKindOfArray
{
    class WhatKindOfArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];

            //enter array elements
            for (int index = 0; index < myArray.Length; index++)
            {
                Console.Write("Number {0} = ", index + 1);
                myArray[index] = int.Parse(Console.ReadLine());
            }

            bool isAllEqual = true;
            bool isIncreasing = true;
            bool isStrictlyIncreasing = true;
            bool isDecreasing = true;
            bool isStrictlyDecreasing = true;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] != myArray[i + 1])
                {
                    isAllEqual = false;
                }
                if (myArray[i] < myArray[i + 1])
                {
                    isDecreasing = false;
                }
                if (myArray[i] <= myArray[i + 1])
                {
                    isStrictlyDecreasing = false;
                }
                if (myArray[i] > myArray[i + 1])
                {
                    isIncreasing = false;
                }
                if (myArray[i] >= myArray[i + 1])
                {
                    isStrictlyIncreasing = false;
                }
            }

            if (isAllEqual)
            {
                Console.WriteLine("All equal");
            }
            else if (isStrictlyIncreasing)
            {
                Console.WriteLine("Strictly increasing");
            }
            else if (isIncreasing)
            {
                Console.WriteLine("Increasing");
            }
            else if (isStrictlyDecreasing)
            {
                Console.WriteLine("Strictly Decreasing");
            }
            else if (isDecreasing)
            {
                Console.WriteLine("Decreasing");
            }
            else
            {
                Console.WriteLine("Unsorted");
            }
        }
    }
}
