//  Намерете сумата от крайните елементи на матрицата A(M,N).
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
            int[,] a = new int[4, 5]
            {
                {5, 1, 6, -9, 4},
                {3, 7, -5, 0, -3},
                {-1, 4, -2, 6, 3},
                {-1, 4, -2, 6, 3}
            };

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            int sum = 0;

            for (int i = 0; i < cols; i++)
            {
                sum += a[0, i];
                sum += a[rows - 1, i];
            }

            for (int i = 1; i < rows - 1; i++)
            {
                sum += a[i, 0];
                sum += a[i, cols - 1];
            }

            Console.WriteLine("Sum = {0}", sum);
        }
    }
}