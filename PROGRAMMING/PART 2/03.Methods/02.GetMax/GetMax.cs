/*Напишете метод GetMax() с два int параметъра, който връща по-големия от двата.
 * Напишете програма, която чете 3 цели числа от конзолата и отпечатва най-голямото от тях
 * използвайки GetMax().    */
using System;

class program
    {
        static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;

            // second variant

            //if (n1 > n2)
            //{
            //    return n1;
            //}
            ////else
            ////{
            ////    return n2;
            ////}
            //return n2;
        }
        static void Main()
        {
            Console.Write("n1 = ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.Write("n3 = ");
            int n3 = Int32.Parse(Console.ReadLine());

            int max = GetMax(n1, GetMax(n2, n3));
            Console.WriteLine("Max = {0}",max);
        }
    }