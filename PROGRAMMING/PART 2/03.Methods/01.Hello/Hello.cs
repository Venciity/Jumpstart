/*Напишете метод който пита потребителя за неговото име и отпечатва "Hello, <name>!" (Например "Hello, Peter!").
 * Напишете програма която тества този метод.*/
using System;

    class Hello
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main()
        {
            PrintName("John");
            //string name = "Marry";
            //PrintName(name);
        }
    }