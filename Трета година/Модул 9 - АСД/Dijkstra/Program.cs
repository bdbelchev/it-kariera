using System.Collections.Generic;

namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<int, int>> weightedGraph = new Dictionary<int, Dictionary<int, int>>();

            AddEdge(weightedGraph, 0, 6, 10);
            AddEdge(weightedGraph, 0, 8, 12);
            AddEdge(weightedGraph, 6, 4, 17);
            AddEdge(weightedGraph, 6, 5, 6);
            AddEdge(weightedGraph, 8, 5, 3);
            AddEdge(weightedGraph, 8, 2, 14);
            AddEdge(weightedGraph, 4, 5, 5);
            AddEdge(weightedGraph, 4, 11, 11);
            AddEdge(weightedGraph, 4, 1, 20);
            AddEdge(weightedGraph, 5, 11, 33);
            AddEdge(weightedGraph, 2, 11, 9);
            AddEdge(weightedGraph, 2, 7, 15);
            AddEdge(weightedGraph, 11, 1, 6);
            AddEdge(weightedGraph, 11, 7, 20);
            AddEdge(weightedGraph, 7, 1, 26);
            AddEdge(weightedGraph, 7, 9, 3);
            AddEdge(weightedGraph, 1, 9, 5);
            AddEdge(weightedGraph, 3, 10, 7);

            Dijkstra(weightedGraph, 0, 9);
        }

        private static void Dijkstra(Dictionary<int, Dictionary<int, int>> graph, int root, int target)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            int[] distances = new int[graph.Count];
            int[] prev = new int[graph.Count];
            bool[] visited = new bool[graph.Count];

            for (int i = 0; i < graph.Count; i++)
            {
                distances[i] = int.MaxValue;
                prev[i] = -1;
            }

            queue.Enqueue(root, 0);
            distances[root] = 0;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (!visited[current])
                {
                    visited[current] = true;
                    foreach (KeyValuePair<int, int> child in graph[current])
                    {
                        int distanceFromStart = distances[child.Key];
                        int distanceFromParent = distances[current] + child.Value;

                        if (distanceFromStart > distanceFromParent)
                        {
                            distances[child.Key] = distanceFromParent;
                            prev[child.Key] = current;
                        }
                        else
                        {
                            distances[child.Key] = distanceFromStart;
                        }

                        queue.Enqueue(child.Key, distances[child.Key]);
                    }
                }
            }

            LinkedList<int> path = new LinkedList<int>();

            int previousNode = target;

            while (previousNode != -1)
            {
                path.AddFirst(previousNode);
                previousNode = prev[previousNode];
            }

            Console.WriteLine(string.Join(" -> ", path) + $" ({distances[target]})");
        }

        private static void AddEdge(Dictionary<int, Dictionary<int, int>> graph, int parent, int child, int weight)
        {
            if (!graph.ContainsKey(parent))
            {
                graph.Add(parent, new Dictionary<int, int>() { { child, weight } });
            }
            else
            {
                graph[parent].Add(child, weight);
            }

            if (!graph.ContainsKey(child))
            {
                graph.Add(child, new Dictionary<int, int>() { { parent, weight } });
            }
            else
            {
                graph[child].Add(parent, weight);
            }
        }
    }

}