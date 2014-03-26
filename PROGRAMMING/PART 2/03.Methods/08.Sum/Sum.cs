/*Напишете метод, който събира две положителни числа представени като масиви от цифри
 * (всеки елемент arr[i] съдържа една цифра; последната цифра се пази в arr[0]).
 * Всяко от двете числа може да има до 10000 на брой цифри.    */
using System;
    class Program
    {
        static byte[] Sum(byte[] n1, byte[] n2)
        {
            int maxLen = Math.Max(n1.Length, n2.Length);
            byte[] result = new byte[maxLen + 1];

            int carry = 0;
            int units = 0;

            for (int i = 0; i < result.Length; i++)
            {
                int digitsSum = 0;

                if (i < n1.Length)
                {
                    digitsSum += n1[i];
                }
                if (i < n2.Length)
                {
                    digitsSum += n2[i];
                }

                digitsSum += carry;

                carry = digitsSum / 10;
                units = digitsSum % 10;

                result[i] = (byte)units;
            }

            return result;
        }

        static void Main()
        {
            byte[] n1 = { 0, 5, 3, 7, 1 }; // 17350
            byte[] n2 = { 4, 6, 8, 8 }; // 8864

            byte[] sum = Sum(n1, n2);

            for (int i = sum.Length-1; i >= 0 ; i--)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
        }
    }