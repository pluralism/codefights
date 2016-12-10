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
                new int[] { 0, 3 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },

                new int[] { 2, 5 },
                new int[] { 3, 4 },
                new int[] { 4, 7 },
                new int[] { 5, 6 },

                new int[] { 6, 9 },
                new int[] { 6, 5 },
                new int[] { 7, 8 },
                new int[] { 8, 14 },

                new int[] { 8, 25 },
                new int[] { 9, 10 },
                new int[] { 10, 11 },
                new int[] { 11, 12 },

                new int[] { 12, 13 },
                new int[] { 13, 27 },
                new int[] { 14, 13 },
                new int[] { 16, 17 },

                new int[] { 16, 8 },
                new int[] { 17, 18 },
                new int[] { 18, 19 },
                new int[] { 18, 6 },

                new int[] { 19, 20 },
                new int[] { 19, 9 },
                new int[] { 19, 22 },
                new int[] { 20, 23 },

                new int[] { 21, 22 },
                new int[] { 21, 27 },
                new int[] { 22, 19 },
                new int[] { 22, 21 },

                new int[] { 23, 24 },
                new int[] { 23, 18 },
                new int[] { 24, 20 },
                new int[] { 25, 6 },

                new int[] { 27, 16 }
            };

            int[] markedNodes = new int[] { 25, 27, 5 };


            PathFinding pf = new PathFinding();
            pf.pathfinding(0, edges, markedNodes);
            Console.ReadLine();
        }
    }
}
