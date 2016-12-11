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
            int[][] edges = new int[][]
            {
            };

            int[] markedNodes = new int[] { 7 };


            Console.WriteLine(PathFinding.pathfinding(7, edges, markedNodes));
            Console.ReadLine();
        }
    }
}
