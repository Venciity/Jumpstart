/*Задача М1-32.
 * Дадени са три сортирани в нарастващ ред масиви A(M),B(N) и C(P).
 * Да се определи един набор от индекси, за които Ai=Bj=Ck.
 * Пред­полага се, че такива индекси съществуват.
 
 NOTE :  програмата разботи за всички набори от индексти :)   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.SameNumbers
{
    class SameNumbers
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4, 5, 6, 7, 9 };
            int[] b = { 1, 2, 3, 4, 5, 6, 8 };
            int[] c = { 4, 6, 9, 10 };

            int ai = 0, bi = 0, ci = 0; // индекси за масивите a,b,c

            while (true)
            {
                int max = Math.Max(a[ai], Math.Max(b[bi], c[ci])); // намираме максималното число

                while (ai < a.Length && a[ai] < max)
                {
                    ai++;
                }
                if (ai >= a.Length)
                {
                    break;
                }

                while (bi < b.Length && b[bi] < max)
                {
                    bi++;
                }
                if (bi >= b.Length)
                {
                    break;
                }

                while (ci < c.Length && c[ci] < max)
                {
                    ci++;
                }
                if (ci >= c.Length)
                {
                    break;
                }

                if (a[ai] == b[bi] && b[bi] == c[ci])
                {
                    Console.WriteLine("{0} {1} {2}", ai, bi, ci);
                    ai++; bi++; ci++;

                    if (ai >= a.Length || bi >= b.Length || ci >= c.Length)
                    {
                        break;
                    }
                }
            }
        }
    }
}
