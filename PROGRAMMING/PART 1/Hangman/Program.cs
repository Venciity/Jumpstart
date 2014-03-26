using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "pear", "apricot", "peach", "cherry", "melon", 
                                "avocado","banana","coconut","mango" };

            Random random = new Random();
            int index = random.Next(fruits.Length);

            string word = fruits[index];

            int guessesLeft = 5;

            bool[] isLetterShown = new bool[word.Length];

            Console.WriteLine("Guess the word!");
            int guessedLetters = 0;

            while (true)
            {
                Console.Write("Result: ");
                for (int i = 0; i < word.Length; i++)
                {
                    if (isLetterShown[i])
                        Console.Write(word[i]);
                    else
                        Console.Write(" _ ");
                }
                Console.WriteLine();

                Console.Write("Letter: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine();

                bool hit = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.ToLower(word[i]) == Char.ToLower(keyInfo.KeyChar))
                    {
                        hit = true;
                        if (!isLetterShown[i])
                        {
                            guessedLetters++;
                            isLetterShown[i] = true;
                        }                     
                    }
                }

                if (!hit)
                {
                    guessesLeft--;
                    Console.WriteLine("No hits! You have {0} guesses left!", guessesLeft);
                    Console.WriteLine();
                }

                if (guessesLeft == 0)
                {
                    Console.WriteLine("Game Over! X__X");
                    Console.WriteLine("The word is: {0}", word);
                    break;
                }

                if (guessedLetters == word.Length)
                {
                    Console.WriteLine("Congratulations! You win!");
                    Console.WriteLine("The word is: {0}", word);
                    break;
                }
            }
        }
    }
}
