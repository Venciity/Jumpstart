/*Задача М1-17.
 * Дадена е редица от цели чис­ла, различни от нула.
 * Преб­рой­те двой­ките съседни членове, които имат раз­лич­ни знаци.      */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Neighbours
{
    class Neighbours
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

            int count = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int sign1 = (myArray[i] < 0) ? -1 : 1;
                int sign2 = (myArray[i + 1] < 0) ? -1 : 1;

                if (sign1 * sign2 == -1)
                {
                    count++;
                }
            }
            Console.WriteLine("Count = {0}", count);
        }
    }
}
