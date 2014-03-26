/* Дадена е матрицата A(M,N). При зададено k, намерете: 
 * най-малкия еле­мент под k-тия ред.   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MinUnderKRow
{
    class MinUnderKRow
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

            if (k < rows - 1)
            {
                int row = k + 1;
                int col = 0;
                int min = a[k + 1, 0];

                for (int i = k + 1; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (min > a[i, j])
                        {
                            min = a[i, j];
                            row = i;
                            col = j;
                        }
                    }
                }
                Console.WriteLine("Min element at row #{0} and col #{1} is {2}", row, col, min);
            }
        }
    }
}