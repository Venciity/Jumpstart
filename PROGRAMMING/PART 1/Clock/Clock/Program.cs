using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int hour = 0;
            //int minute = 0;
            //string time = "";

            //do
            //{
            //    Console.WriteLine("Въведете час във формат чч:мм");
            //    string timeString = Console.ReadLine();

            //    string[] elements = timeString.Split(':');
                
            //    if (elements.Length != 2)
            //        continue;

            //    hour = Int32.Parse(elements[0]);
            //    minute = Int32.Parse(elements[1]);
            //} while (hour < 0 || hour > 23 || minute < 0 || minute > 59);

            while (true)
            {
                Console.Clear();
                DateTime currentTime = DateTime.Now;

                string hourString = ConvertTimeUnitsToString(currentTime.Hour, true);
                string minuteString = ConvertTimeUnitsToString(currentTime.Minute, false);
                string secondString = ConvertTimeUnitsToString(currentTime.Second, false);

                Console.WriteLine(hourString + " часа и "
                    + minuteString + (currentTime.Minute == 1 ? " минута" : " минути")
                    + " и " + secondString + (currentTime.Second == 1 ? " секунда" : " секунди"));

                System.Threading.Thread.Sleep(200);
            }
        }

        //Converts time units (hours, minutes or seconds) to word
        private static string ConvertTimeUnitsToString(int unit, bool isHour)
        {
            string time = "";

            int ones = unit % 10;
            int tens = unit / 10;

            string unitOnesString = ConvertDigitToString(ones, isHour);
            string unitOnesMasculineString = ConvertDigitToString(ones, true);
            string unitTensString = ConvertDigitToString(tens, true);

            if (tens == 0) // 1 2 3 4 5 6 7 8 9
                time += unitOnesString;
            else if (tens == 1) //1x
            {
                if (ones == 0) //10
                {
                    //do nothing
                }
                else if (ones == 1) //11
                    time += unitOnesMasculineString + "а";
                else //12 13 14 15 16 17 18 19
                    time += unitOnesMasculineString + "на";

                time += "десет";
            }
            else
            {
                if (ones == 0) //10 20 30 40 50
                    time += unitTensString + "десет";
                else //21 22 ... 28 29 31 32 33 ... 39 41 42 ... 48 49 51 ... 59
                    time += unitTensString + "десет и " + unitOnesString;
            }

            return time;
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
