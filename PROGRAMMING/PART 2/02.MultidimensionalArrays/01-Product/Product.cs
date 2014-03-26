/* Дадена е матрицата A(M,N). При зададено k, намерете:
    най-големия еле­мент зад k-тия стълб. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MinBeforeKCol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k: ");
            int k = Int32.Parse(Console.ReadLine());

            int[,] a = new int[3, 5]
            {
                {5, 1, 6, 9, 4},
                {3, 7, 5, 0, 3},
                {1, 4, 2, 6, 3}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            long product = 1;
            for (int i = 0; i < rows; i++)
            {
                if (i != k)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (a[i, j] != 0)
                        {
                            product *= a[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("The product is {0}", product);
        }
    }
}