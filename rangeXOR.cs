using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int rangeXOR(int a, int b)
        {
            for (int i = a; i++ < b; a ^= i) ;
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(rangeXOR(2, 4));
            Console.ReadLine();
        }
    }
}
