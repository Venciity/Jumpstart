/* Дадена е матрицата A(M,N). При зададено k, намерете:
    най-големия от еле­мен­ти­те над k-тия ред. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MaxOverKRow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k: ");
            int k = Int32.Parse(Console.ReadLine());

            int[,] a = new int[3, 5]
            {
                {5, 1, 6, 3, 4},
                {3, 7, 5, 8, 3},
                {1, 4, 2, 6, 3}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            if (k > 0)
            {
                int row = 0;
                int col = 0;
                int max = a[0, 0];

                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (max < a[i, j])
                        {
                            max = a[i, j];
                            row = i;
                            col = j;
                        }
                    }
                }
                Console.WriteLine("Max element at row #{0} and col #{1} is {2}", row, col, max);
            }
        }
    }
}
