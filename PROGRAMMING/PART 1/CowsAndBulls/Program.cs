using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowsAndBulls
{
    class Program
    {
        public static bool IsValidNumber(string number, int length)
        {
            if (number.Length != length)
                return false;

            for (int i = 0; i < length; i++)
            {
                if (!Char.IsDigit(number[i]))
                {
                    return false;
                }
            }

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (number[i] == number[j])
                        return false;
                }
            }

            return true;     
        }

        static void Main(string[] args)
        {
            int length = 4;

            string number1, number2;

            while (true)
            {
                Console.Write("Player1 secret number: ");
                Console.BackgroundColor = ConsoleColor.Gray;
                number1 = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;

                if (IsValidNumber(number1, length))
                    break;
            }
            
            while (true)
            {
                Console.Write("Player2 secret number: ");
                Console.BackgroundColor = ConsoleColor.Gray;
                number2 = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;

                if (IsValidNumber(number2, length))
                    break;
            }

            Console.WriteLine();

            int guessingPlayer = 1;
            string guess;

            while (true)
            {
                while (true)
                {
                    Console.Write("Player{0} guess: ", guessingPlayer);

                    guess = Console.ReadLine();

                    if (IsValidNumber(guess, length))
                        break;
                }

                string numberToGuess = (guessingPlayer == 1) ? number2 : number1;

                int bulls = 0;
                int cows = 0;

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (guess[i] == numberToGuess[j])
                        {
                            if (i == j)
                                bulls++;
                            else
                                cows++;
                            break;
                        }
                    }
                }

                Console.WriteLine("Result: {0} bulls {1} cows", bulls, cows);
                Console.WriteLine();

                if (bulls == length)
                {
                    Console.WriteLine("Congratulations Player{0}! You won!", guessingPlayer);
                    int opponent = guessingPlayer == 1 ? 2 : 1;
                    Console.WriteLine("Sorry Player{0}, you suck!", opponent);
                    break;
                }

                guessingPlayer = guessingPlayer == 1 ? 2 : 1;
            }
        }
    }
}
