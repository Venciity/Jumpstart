/*Напишете метод, който обръща цифрите на дадено decimal число. Например: 256 -> 652    */
using System;
    class Program
    {
        static decimal ReverseDigits(decimal number)
        {
            decimal result = 0;
            while (number != 0)
            {
                result *= 10;
                result += (number % 10);
                number = Math.Truncate(number / 10);
            }
            return result;
        }

        static decimal ReverseDigits2(decimal number) // за дробни числа
        {
            bool isNegative = false;
            if (number  < 0)
            {
                number = -number;
                isNegative = true;
            }

            var d =  Decimal.Parse(ReverseString(number.ToString()));
            if (isNegative)
            {
                d = -d;
            }
            return d;

            //string decimalStr = number.ToString();
            //string reversedStr = ReverseString(decimalStr);
            //decimal d = Decimal.Parse(reversedStr);
            //return d;
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            return result;
        }

        static void Main()
        {
             decimal d = -24355660.312m;
             Console.WriteLine("Number = {0}",d);
             Console.WriteLine("Reverse number = {0}",ReverseDigits2(d));
        }
    }