using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codefights_cs
{
    class PathFinding
    {
        /*
         * Given a graph as a list of its edges, your task is to find the shortest path that starts at a start 
         * and visits each of the markedNodes exactly once. 
         * If it's impossible to do this, return -1 instead.
         */
        public int pathfinding(int start, int[][] edges, int[] markedNodes)
        {
            // Create a Dictionary for faster edge lookup
            Dictionary<int, List<int>> edgesDict = new Dictionary<int, List<int>>();

            List<int> outVal;
            // Iterate over the list of all edges to create the keys
            foreach (int[] edge in edges)
            {
                /**
                 * edge[0] represents the source vertex
                 * edge[1] represents the targe vertex
                 */
                if (!edgesDict.TryGetValue(edge[0], out outVal))
                    edgesDict.Add(edge[0], new List<int>());
            }

            /**
             * Create the connections between the vertexes
             * 
             * Each source vertex can be conneced to a list of target vertexes
             */
            foreach (int[] edge in edges)
                edgesDict[edge[0]].Add(edge[1]);

            return -1;
        }
    }
}
