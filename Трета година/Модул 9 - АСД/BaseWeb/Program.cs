using System.Data;

namespace BaseWeb;

static class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] nodes = command.Split(" ").ToArray();

            AddEdge(graph, nodes[0], nodes[1]);

            command = Console.ReadLine();
        }

        List<List<string>> subgraphs = FindSubGraphsInGraph(graph);

        List<Dictionary<string, List<string>>> baseWebs = new List<Dictionary<string, List<string>>>();

        foreach (List<string> subgraph in subgraphs)
        {
            Dictionary<string, List<string>> baseWeb = new Dictionary<string, List<string>>();

            string centralNode = null;

            foreach (string node in subgraph)
            {
                if (graph[node].SequenceEqual(subgraph.Where(x => x != node)))
                {
                    centralNode = node;

                }
            }

            foreach (string node in subgraph)
            {
                if (node != centralNode && (graph[node].Count > 3 || !graph[node].Contains(centralNode)))
                {
                    break;
                }

                baseWeb.Add(node, graph[node]);
            }

            baseWebs.Add(baseWeb);
        }

        if (!baseWebs.All(x => x.Count == 0))
        {
            foreach (KeyValuePair<string, List<string>> edge in baseWebs.OrderBy(x => x.Count).Where(x => x.Count > 2).FirstOrDefault())
            {
                foreach (string child in edge.Value)
                {
                    Console.WriteLine($"{edge.Key} <-> {child}");
                }
            }
        }
        else
        {
            Console.WriteLine("No web...");
        }
    }

    private static List<List<string>> FindSubGraphsInGraph(Dictionary<string, List<string>> graph)
    {
        List<List<string>> subgraphs = new List<List<string>>();
        foreach (string node in graph.Keys)
        {
            if (!subgraphs.Any(x => x.Contains(node)))
            {
                subgraphs.Add(new List<string>());
                DFS(graph, node, subgraphs.Last());
            }
        }
        return subgraphs;
    }

    private static void DFS(Dictionary<string, List<string>> graph, string currentNode, List<string> visited)
    {
        if (!visited.Contains(currentNode))
        {
            visited.Add(currentNode);
            foreach (string child in graph[currentNode])
            {
                DFS(graph, child, visited);
            }
        }
    }

    private static void AddEdge(Dictionary<string, List<string>> graph, string parent, string child)
    {
        if (!graph.ContainsKey(parent))
        {
            graph.Add(parent, new List<string>());
        }

        if (!graph.ContainsKey(child))
        {
            graph.Add(child, new List<string>());
        }

        graph[parent].Add(child);
        graph[child].Add(parent);
    }
}