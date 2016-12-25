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
            Console.WriteLine(BrAille.brAIlle(new string[] { "# # # # #  ", "#   # # # #", "#   #   #  " }));
            Console.ReadLine();
        }
    }
}
