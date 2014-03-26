/*Задача 1
При въведено положително число N от потребителя, отпечатва всички двойки числа в интервала [1..N] 
 * с изключение на двойките съставени от еднакви числа.
Пример:
N = 3
1 2
1 3
2 1
2 3
( не се отпечатват двойките 1 1, 2 2, 3 3)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.From1ToN
{
    class From1ToN
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("number = ");
                n = Int32.Parse(Console.ReadLine());
            } while (n <= 1); // за единицата няма двойки

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine(i + " " + j);
                    }
                }
            }
        }
    }
}
