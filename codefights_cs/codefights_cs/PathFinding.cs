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
             * Each source vertex can be connected to a list of target vertexes
             */
            foreach (int[] edge in edges)
                edgesDict[edge[0]].Add(edge[1]);

            
            /**
             * This dictionary contains all the distances from the start node
             * to all other nodes
            */
            Dictionary<int, int> distFromStart = BFS(edgesDict: edgesDict, start: start);

            foreach(int key in distFromStart.Keys)
                Console.WriteLine(key);

            return -1;
        }


        public Dictionary<int, int> BFS(int start, Dictionary<int, List<int>> edgesDict)
        {
            /**
             * Each element in the Queue Q is composed by 
             * a tuple that contains the following elements:
             * 
             *  - Node
             *  - Cost  
             */
            Queue<Tuple<int, int>> Q = new Queue<Tuple<int, int>>();
            Q.Enqueue(Tuple.Create(start, 0));

            // Contains the vertexes that were already discovered
            HashSet<int> discovered = new HashSet<int>();

            // Holds the cost of the shortest path between the start and all other vertexes
            Dictionary<int, int> costs = new Dictionary<int, int>();

            // Run while the Queue object is not empty
            while(Q.Count > 0)
            {
                // Removes and returns the first inserted element (node + cost associated)
                Tuple<int, int> current = Q.Dequeue();

                // The vertex was already discovered, just continue...
                if (discovered.Contains(current.Item1))
                    continue;

                /**
                 * Add the information that represents the cost from reaching the
                 * current Node from the start node
                 * 
                 * The key is the node and the value is the cost
                 */
                costs.Add(current.Item1, current.Item2);

                // The vertex was not discovered yet, add it to the discovered vertexes
                discovered.Add(current.Item1);

                // Iterate over all the adjacent vertexes...
                foreach(int n in edgesDict[current.Item1])
                {
                    /**
                     * If the vertex v was not still discovered insert a 
                     * new tuple in the queue. The cost associated with the new vertex
                     * is the cost of the current vertex + 1 (one level deeper in the tree)
                     */
                    if (!discovered.Contains(n))
                        Q.Enqueue(Tuple.Create(n, current.Item2 + 1));
                }
            }


            return costs;
        }
    }
}
