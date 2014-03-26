/*Матрицата A(M,N) пре­хвър­лена в масива B(K) по стъл­бо­ве.
 *При зададени i и j, да се оп­ре­дели индекса на елемента Aij в масива В.  */

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
            //Console.WriteLine("Enter i= ");
            //int i = Int32.Parse(Console.ReadLine());

            int[,] a = new int[3, 5]
            {
                {0, 3, 6, 9, 12},
                {1, 4, 7, 10, 13},
                {2, 5, 8, 11, 14}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int[] b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            int i = 1;  // РЕД 1
            int j = 4;  // КОЛОНА 4

            int k = j * rows + i;
        }
    }
}