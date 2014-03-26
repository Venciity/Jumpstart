//  Дадена е матрицата A(M,N). Намерете номера на стълба с най-мно­го от­ри­ца­тел­ни елементи.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NegaitveElements
{
    class NegaitveElements
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

            int maxCol = 0;
            int maxCount = 0;

            for (int i = 0; i < cols; i++)
            {
                int count = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (a[j, i] < 0)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxCol = i;
                }
            }

            Console.WriteLine("Column = {0}, count = {1}", maxCol, maxCount);
        }
    }
}