/* Дадена е матрицата A(M,N). При зададено k, намерете:
    най-малкия еле­мент пред k-тия стълб. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MinBeforeKCol
{
    class MinBeforeKCol
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

            if (k > 0)
            {
                int row = 0;
                int col = 0;
                int min = a[row, col];

                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (min > a[j, i])
                        {
                            min = a[j, i];
                            row = j;
                            col = i;
                        }
                    }
                }
                Console.WriteLine("Min element at row #{0} and col #{1} is {2}", row, col, min);
            }
        }
    }
}