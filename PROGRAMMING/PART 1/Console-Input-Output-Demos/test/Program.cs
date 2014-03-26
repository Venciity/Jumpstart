using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    Console.WriteLine("You pressed : {0}" , key.Key);
                }
            }
        }
    }
}
