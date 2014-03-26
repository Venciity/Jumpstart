using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specificPosition_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 5;
            int n = 35;                         //00100011
            int mask = 1 << position;           //00100000
            int nAndMask = n & mask;            //00100000
            int bit = nAndMask >> position;     //00000001

            Console.WriteLine("current bit value: {0}", bit);   //1

            ////също така можем да го проверим директно дали 1
            //bool isone = (n & mask) == mask;
            //Console.WriteLine("Is one = {0}",isone);
            ////или нула
            //bool iszero = (n & mask) == 0;
            //Console.WriteLine("Is zero = {0}", iszero);
        }
    }
}