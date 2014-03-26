/*Задача М1-18.
 * В масив, подреден в на­раст­ващ ред, по невнимание на неиз­вест­но мяс­то е записано число.
 * Ако числото на­ру­ша­ва подредбата, да се намери не­го­вият index.      */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.AscendingOrder
{
    class AscendingOrder
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

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] > myArray[i + 1])
                {
                    Console.WriteLine("Index : {0}",i + 1);
                    break;
                }
            }
        }
    }
}
