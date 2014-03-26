using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitTearDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 5;
            int n = 35;                                     //00100011
            int mask = ~(1 << p);                           //11011111
            int result = n & mask;                          //00000011
            Console.WriteLine("Result: {0}",result);        //3
        }
    }
}