using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                DateTime currentTime = DateTime.Now;
                int hour = currentTime.Hour;
                int minute = currentTime.Minute;
                int second = currentTime.Second;

                PrintPart(true, hour);
                
                Print("часа,", true);
                PrintPart(false, minute);
                Print("минути и", true);
                PrintPart(false, second);
                Print("секунди", true);

                System.Threading.Thread.Sleep(200);
            }
        }

        private static void PrintPart(bool isHour, int unit)
        {
            int partOnes = unit % 10;
            int partTens = unit / 10;

            //00
            Print(ConvertDigitToString(0, isHour), partOnes == partTens && partTens == 0);

            for (int i = 1; i <= 9; i++)
            {
                bool highlight = 
                    //11 12 13 14 15 16 17 18 19
                    (partTens == 1 && i == partOnes) ||
                    //20 21 .. 58 59
                    (partTens > 1 && i == partTens);

                Print(ConvertDigitToString(i, true), highlight);
                
            }

            Console.WriteLine();

            Print("н", partTens == 1 && partOnes > 1); //12 13 14 15 16 17 18 19
            Print("а", partTens == 1 && partOnes > 0); //11 12 13 14 15 16 17 18 19

            //10 11 12 .... 59
            Print("десет", partTens > 0); 

            // 21 22 23 ... 29 31 32 .. 39 41 42 .. 49 51 52 .. 59
            Print("и", partTens > 1 && partOnes != 0);

            for (int i = 1; i <= 9; i++)
            {
                bool highlight =
                    //1 2 3 4 5 6 7 8 9
                    (partTens == 0 && i == partOnes) ||
                    // 21 22 23 ... 29 31 32 .. 39 41 42 .. 49 51 52 .. 59
                    (partTens > 1 && i == partOnes); 

                Print(ConvertDigitToString(i, isHour), highlight);
            }
            Console.WriteLine();

        }

        private static void Print(string text, bool highlight)
        {
            if (highlight)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write(text);
        }

        private static string ConvertDigitToString(int digit, bool masculine)
        {
            switch (digit)
            {
                case 0:
                    return "нула";
                case 1:
                    return masculine ? "един" : "една";
                case 2:
                    return masculine ? "два" : "две";
                case 3:
                    return "три";
                case 4:
                    return "четири";
                case 5:
                    return "пет";
                case 6:
                    return "шест";
                case 7:
                    return "седем";
                case 8:
                    return "осем";
                case 9:
                    return "девет";
                default:
                    return "";
            }
        }
    }
}
