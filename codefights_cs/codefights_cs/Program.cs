using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = CodeFight.codeFight(35);
            foreach (string s in a)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
