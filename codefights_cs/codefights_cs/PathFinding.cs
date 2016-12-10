using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codefights_cs
{
    class PathFinding
    {
        static int currentBest = Int32.MaxValue;

        /*
         * Given a graph as a list of its edges, your task is to find the shortest path that starts at a start 
         * and visits each of the markedNodes exactly once. 
         * If it's impossible to do this, return -1 instead.
         */
        public int pathfinding(int start, int[][] edges, int[] markedNodes)
        {
            // Remove the start node from the markedNodes array
            markedNodes = markedNodes.Where(n => n != start).ToArray();

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
             * 
             * Each element in the dictionary has the node index as the key and the
             * distance as value
            */
            // Dictionary<int, int> distFromStart = BFS(edgesDict: edgesDict, start: start);

            // Do the same thing for each vertex that is in the marked nodes
            Dictionary<int, Dictionary<int, int>> nodesDict = new Dictionary<int, Dictionary<int, int>>();
            nodesDict.Add(start, BFS(edgesDict: edgesDict, start: start));


            /**
             * Afer this loop we have an array where each element has the distance from a marked node
             * to all other nodes
            */
            for (int i = 0; i < markedNodes.Length; i++)
                nodesDict.Add(markedNodes[i], BFS(start: markedNodes[i], edgesDict: edgesDict));


            /**
             * Now we need to compute the shortest distance between the relevant nodes.
             * In this case the relevant nodes can be considered the marked nodes
             */
            calculateBestCost(node: start, nodesDict: nodesDict, markedNodes: markedNodes.ToList(), 
                currentCost: 0, visited: new List<int>());

            return currentBest == Int32.MaxValue ? -1 : currentBest;
        }


        // Calculate all paths from a node 
        // Node is the current node that is being analyzed
        // nodesDict is the list of all nodes and the respective distances to other nodes
        // startNode is the start node of the program 
        public void calculateBestCost(Dictionary<int, Dictionary<int, int>> nodesDict, List<int> markedNodes, 
            int node, int currentCost, List<int> visited)
        {
            if (markedNodes.Count == 0)
                currentBest = Math.Min(currentBest, currentCost);

            // Label "node" as discovered if not labeled already
            if (!visited.Contains(node))
                visited.Add(node);


            // Extract the neighboors of the current node
            Dictionary<int, int> neighboors = nodesDict[node];
            // Iterate over all neighboors...
            foreach(KeyValuePair<int, int> pair in neighboors)
            {
                // We only want to analyze nodes in markedNodes list...
                if(markedNodes.Contains(pair.Key))
                {
                    if(!visited.Contains(pair.Key) && pair.Value > 0)
                    {
                        if (currentCost + pair.Value >= currentBest)
                            return;

                        List<int> newMarkedNodes = new List<int>(markedNodes);
                        newMarkedNodes.Remove(pair.Key);

                        calculateBestCost(nodesDict, newMarkedNodes, pair.Key, currentCost + pair.Value, visited);
                    }
                }
            }
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

            // Holds the cost of the shortest path between a given node and all other vertexes
            // The key is the target node and the value is the cost of traveling from source to target
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

            // If there is no connection to a vertex then we put the distance as -1
            foreach(KeyValuePair<int, List<int>> p in edgesDict)
                if (!costs.ContainsKey(p.Key))
                    costs.Add(p.Key, -1);

            return costs;
        }
    }
}
