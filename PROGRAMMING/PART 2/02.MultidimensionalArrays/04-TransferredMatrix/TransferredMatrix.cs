/*Матрицата A(M,N) е пре­хвър­лена в масива B(K) по ре­до­ве.
 *При зададено i, да се оп­ре­делят индексите на елемента Bi в мат­рицата A.    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NegaitveElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i= ");
            int i = Int32.Parse(Console.ReadLine());

            int[,] a = new int[3, 5]
            {
                {0, 1, 2, 3, 4},
                {5, 6, 7, 8, 9},
                {10, 11, 12, 13, 14}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int[] b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            int row = i / cols;
            int col = i % cols;

            // int k = row * cols + col;  обратното
        }
    }
}