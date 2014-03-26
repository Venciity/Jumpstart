/*Задача М1-13.
 * Даден е ма­сив А(N) и чис­ло­то В. 
 * Определете стойността на най-малкия еле­мент от масива, който е по-голям от числото В 
 * и но­мерата  на елементите с тази стойност.      */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MinElement
{
    class MinElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];

            //enter array elements
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Number {0} = ", i + 1);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());

            int index = 0;
            while (index < myArray.Length && myArray[index] <= b)
            {
                index++;
            }

            if (index == myArray.Length)
            {
                Console.WriteLine("No number geater than {0} is found", b);
            }
            else
            {
                int min = myArray[index];
                for (int j = index + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < min && myArray[j] > b)
                    {
                        min = myArray[j];
                    }
                }
                Console.WriteLine("Smallest number greater than {0} is {1}", b, min);

                Console.Write("Possitions: ");
                for (int j = index + 1; j < myArray.Length; j++)
                {
                    if (min == myArray[j])
                    {
                        Console.Write("{0} ", j);
                    }
                }
            }
        }
    }
}