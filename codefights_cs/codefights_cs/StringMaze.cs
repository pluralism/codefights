using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class StringMaze
    {
        public static int stringMaze(string maze)
        {
            // Holds the position that were already visited
            bool[] visited = new bool[maze.Length];
            // Holds the current index in the string
            int index = 0;
            // Holds the number of moves
            int moves = 0;

            while(true)
            {
                if (visited[index])
                    return -1;
                if (index == maze.Length - 1)
                    return moves;

                visited[index] = true;
                moves += 1;
                index = (index + ((int)maze[index] - 96)) % maze.Length;
            }
        }
    }
}
