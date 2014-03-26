/* Дадена е матрицата A(M,N). При зададено k, намерете:
    най-големия от еле­мен­ти­те над k-тия ред.
    най-малкия еле­мент под k-тия ред.
    произ­ве­де­ние­то на не­нулевите елементи без тези от k-тия ред.
    произ­ве­де­ние­то на еле­ментите без тези от k-тия стълб.
    най-малкия еле­мент пред k-тия стълб.
    най-големия еле­мент зад k-тия стълб. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimentionalArraysHW
{
    class MultidimentionalArraysHW1
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[4, 4]
            {
                {  1,  2,  0, -5 },
                { -2,  3,  0,  7 },
                {  4,  1,  8,  0 },
                {  0, -5, -3,  2 }
            };
            Console.WriteLine("Please enter k: ");
            int k = Int32.Parse(Console.ReadLine());

            int maxAboveKRow = Int32.MinValue;
            int minUnderKRow = Int32.MaxValue;
            int nonZeroProduct = 1;
            int exeptKColumnProduct = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < k)
                        if (matrixA[i, j] > maxAboveKRow)
                            maxAboveKRow = matrixA[i, j];
                    if (i > k)
                        if (matrixA[i, j] < minUnderKRow)
                            minUnderKRow = matrixA[i, j];
                    if (i != k)
                        if (matrixA[i, j] != 0)
                            nonZeroProduct *= matrixA[i, j];
                    if (j != k)
                        exeptKColumnProduct *= matrixA[i, j];
                }
            }
            Console.WriteLine("Max = {0}", maxAboveKRow);
            Console.WriteLine("Min = {0}", minUnderKRow);
            Console.WriteLine("NonZeroProduct = {0}", nonZeroProduct);
            Console.WriteLine("ExeptKColumnProduct = {0}", exeptKColumnProduct);
        }
    }
}
//          int rows = matrixA.GetLength(0);
//          int cols = matrixA.GetLength(1);
//
//          if (k < rows-1)
//          {
//              int row = 0;
//              int col = k-1;
//              int min = matrixA[row, col];
//              for (int i = 0; i < k; i++)
//              {
//                  for (int j  = 0; j < rows; j++)
//                  {
//                      if (min > matrixA[j,i])
//                      {
//                          min = matrixA[j, i];
//                          row = j;
//                          col = i;
//                      }
//                  }
//              }
//              Console.WriteLine("max element at row #{0} and col #{1} is {2}", row, col, min);
//          }