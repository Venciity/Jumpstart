using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Example
    {
        static void Main()
        {
            var list = new List<int>();    //  List<int> list; по-кратък начин на изписване !

            int number;
            do
            {
                number = Int32.Parse(Console.ReadLine());
                if (number != 0)
                {
                    list.Add(number);
                }
            } while (number != 0);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}