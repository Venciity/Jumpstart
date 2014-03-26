/*Върху шахматна дъска NxN са фиксирани две полета, за­да­дени с коор­динатите си P1,Q1 и P2,Q2.
 * Посочете пътя за придвижване на цар от пър­во­то зададено поле до второто поле с ми­ни­ма­лен брой хо­до­ве.
 * За целта използвайте матрица като обходените полета обозначите в матрицата с 1 а останалите с 0. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Chess
{
    class Chess
    {
        static void Main(string[] args)
        {
            int n = 8;
            int p1 = 2;
            int q1 = 2;
            int p2 = 7;
            int q2 = 7;

            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0
            // 0 0 0 0 0 0 0 0

            int[,] m = new int[n, n];
            m[p1, q1] = 1;
            m[p2, q2] = 1;

            int distanceX = Math.Abs(p1 - p2);
            int distanceY = Math.Abs(q1 - q2);

            int moveDirX = Math.Sign(p2 - p1);
            int moveDirY = Math.Sign(q2 - q1);

            int x = p1;
            int y = q1;

            if (distanceX <= distanceY)
            {
                while (x != p2)
                {
                    m[x, y] = 1;
                    x += moveDirX;
                    y += moveDirY;
                }

                while (y != q2)
                {
                    m[x, y] = 1;
                    y += moveDirY;
                }
            }
            else
            {
                while (y != q2)
                {
                    m[x, y] = 1;
                    x += moveDirX;
                    y += moveDirY;
                }

                while (x != p2)
                {
                    m[x, y] = 1;
                    x += moveDirX;
                }
            }

            for (int row = 0; row < m.GetLength(1); row++)
            {
                for (int col = 0; col < m.GetLength(0); col++)
                {
                    Console.Write(m[col, row] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}