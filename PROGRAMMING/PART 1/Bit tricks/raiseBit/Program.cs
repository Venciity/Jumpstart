using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitRaise
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 4;
            int n = 35;                                     //00100011
            int mask = 1 << p;                              //00010000
            int result = n | mask;                          //00110011
            Console.WriteLine("Result: {0}",result);        //51
        }
    }
}