namespace MinimumSpanningTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string[], int> weightedGraph = new Dictionary<string[], int>();

            AddEdge(weightedGraph, "A", "B", 4);
            AddEdge(weightedGraph, "G", "H", 8);
            AddEdge(weightedGraph, "A", "D", 9);
            AddEdge(weightedGraph, "C", "E", 7);
            AddEdge(weightedGraph, "B", "D", 2);
            AddEdge(weightedGraph, "G", "I", 10);
            AddEdge(weightedGraph, "E", "F", 12);
            AddEdge(weightedGraph, "H", "I", 7);
            AddEdge(weightedGraph, "D", "E", 8);
            AddEdge(weightedGraph, "A", "C", 5);
            AddEdge(weightedGraph, "C", "D", 20);

            Dictionary<string, List<string>> forest = new Dictionary<string, List<string>>();

            Kruskal(forest, weightedGraph);

            foreach (KeyValuePair<string, List<string>> edge in forest)
            {
                string node1 = edge.Key;
                foreach (string node2 in forest[node1])
                {
                    Console.WriteLine($"{node1} <-> {node2}: {weightedGraph.FirstOrDefault(x => x.Key.SequenceEqual(new[] { node1, node2 })).Value}");
                }
            }
        }

        private static void Kruskal(Dictionary<string, List<string>> tree, Dictionary<string[], int> graph)
        {
            graph = graph.OrderBy(x => x.Value).ToDictionary(p => p.Key, p => p.Value);
            foreach (KeyValuePair<string[], int> edge in graph)
            {
                string parent = edge.Key[0];
                string child = edge.Key[1];

                if (FindRoot(tree, parent) != FindRoot(tree, child))
                {
                    if (tree.ContainsKey(parent))
                    {
                        tree[parent].Add(child);
                    }
                    else
                    {
                        tree.Add(parent, new List<string>() { child });
                    }
                }
            }
        }

        private static string FindRoot(Dictionary<string, List<string>> tree, string node)
        {
            string parent = tree.FirstOrDefault(e => e.Value.Contains(node)).Key;

            if (parent == null)
            {
                return node;
            }

            return FindRoot(tree, parent);
        }

        private static void AddEdge(Dictionary<string[], int> graph, string parent, string child, int weight)
        {
            graph.Add(new[] { parent, child }, weight);
        }
    }
}