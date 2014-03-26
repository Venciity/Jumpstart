/*Задача М1-15.
 * Установете поредния номер на първия и броя на всички от­ри­ца­тел­ни елементи на ма­сива А(N).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NegativeElements
{
    class NegativeElements
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

            int i = 0;
            while (i < myArray.Length && myArray[i] >= 0)
            {
                i++;
            }
            if (i == myArray.Length)
            {
                Console.WriteLine("there is no negative elements int the array");
            }
            else
            {
                int count = 1;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("The index of first negative element is {0} and " +
                    "the total number of all negative numbers is {1}", i, count);
            }
        }
    }
}
