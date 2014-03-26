using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
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

            int n = list.Count;
            bool swapped;
            do
            {
                int temp;
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        swapped = true;
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }

                n--;
            } while (swapped && n > 1); // обхождай ги докато се разменят или n > 1

            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }
    }
}
