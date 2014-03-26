/*Да се въведе цяло int число N от клавиатурата и да се намерят съответно броя на битовете 0 и 
 * битовете 1 от които е съставено*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnesAndZeros
{
    class OnesAndZeros
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = Int32.Parse(Console.ReadLine());
            int zeros = 0;
            int ones = 0;

            for (int i = 0; i < 32; i++)
            {
                int mask = 1 << i;

                if ((number & mask) == 0)
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }
            }

            Console.WriteLine("ones = {0} , zeros = {1}", ones, zeros);
        }
    }
}
