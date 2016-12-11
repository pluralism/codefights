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
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 0, 3 },
                new int[] { 1, 4 },
                new int[] { 1, 0 },
                new int[] { 2, 1 },
                new int[] { 3, 2 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 5, 3 },
                new int[] { 6, 7 },
                new int[] { 6, 2 },
                new int[] { 7, 8 },
                new int[] { 7, 1 },
                new int[] { 8, 9 },
                new int[] { 9, 10 },
                new int[] { 10, 11 },
                new int[] { 11, 12 },
                new int[] { 12, 2 }
            };

            int[] markedNodes = new int[] { 12, 2 };


            Console.WriteLine(PathFinding.pathfinding(0, edges, markedNodes));
            Console.ReadLine();
        }
    }
}
