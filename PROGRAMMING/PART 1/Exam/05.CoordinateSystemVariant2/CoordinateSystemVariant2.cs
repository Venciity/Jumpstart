// http://jumpstart.bg/csharp/csharpexam1.html#/4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CoordinateSystemVariant2
{
    class CoordinateSystemVariant2
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("y = ");
            int y = Int32.Parse(Console.ReadLine());

            int originX = 10;
            int originY = 5;

            int transformedX = originX + x;
            int transformedY = originY - y + Console.CursorTop;

            for (int row = 0; row < 11; row++)
            {
                if (row == 5)
                {
                    Console.WriteLine("{0}+{0}", new string('-', 10));
                }
                else
                {
                    Console.WriteLine("{0}|", new string(' ', 10));
                }
            }

            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;

            Console.SetCursorPosition(transformedX, transformedY);
            Console.WriteLine("*");

            Console.SetCursorPosition(cursorLeft, cursorTop);

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                else if (y < 0)
                {
                    Console.WriteLine("4");
                }
                else
                {
                    Console.WriteLine("x");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("2");
                }
                else if (y < 0)
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine("x");
                }
            }
            else
            {
                if (y == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("y");
                }
            }
        }
    }
}
