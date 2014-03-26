using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamikadze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = true;
            
            int target1 = 5;
            int target2 = 17;
            int target3 = 12;

            Console.SetWindowSize(20, 25);

            int tries = 2;
            int score = 0;

            while (true)
            {
                Console.Clear();

                PrintTarget(target1);
                PrintTarget(target2);
                PrintTarget(target3);

                int x = Console.WindowWidth / 2;
                int y = Console.WindowHeight - 1;

                PrintPlayer(x, y);

                string title = String.Format("Tries remaining: {0}, score: {1}", tries, score);

                Console.Title = title;
                
                var key = Console.ReadKey();

                if (key.Key != ConsoleKey.UpArrow)
                {
                    Console.CursorLeft--;
                    continue;
                }

                while (true)
                {
                    System.Threading.Thread.Sleep(80);

                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            if (x > 0)
                            {
                                x--;
                                Console.Write(" ");
                            }
                        }
                        else if (key.Key == ConsoleKey.RightArrow)
                        {
                            if (x < Console.WindowWidth - 1)
                            {
                                x++;
                                Console.Write(" ");
                            }
                        }
                    }

                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    y--;

                    if (y < 0)
                        break;
                    else if (y == 0)
                    {
                        if (x == target1)
                        {
                            target1 = -1;
                            score++;
                        }
                        else if (x == target2)
                        {
                            target2 = -1;
                            score++;
                        }
                        else if (x == target3)
                        {
                            target3 = -1;
                            score++;
                        }
                        else
                        {
                            tries--;
                            if( tries == 0)
                            {
                                PrintResult("You lost!");
                                return;
                            }
                        }

                        if (score == 3)
                        {
                            PrintResult("You won!");
                            return;
                        }
                    }

                    PrintPlayer(x, y);
                }
            }
        }

        private static void PrintResult(string result)
        {
            Console.Clear();
            Console.SetCursorPosition(
                Console.WindowWidth / 2 - result.Length / 2,
            Console.WindowHeight / 2);
            Console.WriteLine(result);
            Console.CursorVisible = false;
            Console.ReadKey();
        }

        private static void PrintTarget(int x)
        {
            if (x > -1 &&  x < Console.WindowWidth)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("*");
            }
        }

        private static void PrintPlayer(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("+");
            Console.CursorLeft--;
        }
    }
}
