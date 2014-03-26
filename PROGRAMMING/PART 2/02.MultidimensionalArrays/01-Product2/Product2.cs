/* Дадена е матрицата A(M,N). При зададено k, намерете:
    произведението на елементите без тези от k-тия стълб.   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Product2
{
    class Product2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k: ");
            int k = Int32.Parse(Console.ReadLine());

            int[,] a = new int[3, 3]
            {
                {5, 9, 4},
                {3, 0, 3},
                {1, 6, 3}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            long product = 1;
            for (int i = 0; i < cols; i++)
            {
                if (i != k)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        product *= a[j, i];
                    }
                }
            }
            Console.WriteLine("The product is {0}", product);
        }
    }
}
