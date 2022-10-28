using System.ComponentModel.Design;

static class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, List<int>> tree = new Dictionary<int, List<int>>();

        string command = Console.ReadLine();

        while (command != "calculate")
        {
            int[] nodes = command.Split(" ").Select(int.Parse).ToArray();

            AddEdge(tree, nodes[0], nodes[1]);

            command = Console.ReadLine();
        }

        List<KeyValuePair<int, List<int>>> paths = new List<KeyValuePair<int, List<int>>>();

        DFS(tree, tree.First().Key, 0, new List<int>(), paths);

        foreach (KeyValuePair<int, List<int>> path in paths.OrderByDescending(x=>x.Key).Take(3))
        {
            Console.WriteLine($"{path.Key} -> {string.Join(", ", path.Value)}");
        }
    }

    private static void DFS(Dictionary<int, List<int>> tree, int root,
        int currentValue, List<int> currentPath, List<KeyValuePair<int, List<int>>> paths)
    {
        currentPath.Add(root);
        currentValue += root;

        foreach (int child in tree[root])
        {
            DFS(tree, child, currentValue, currentPath, paths);
        }

        paths.Add(new KeyValuePair<int, List<int>>(currentValue, new List<int>(currentPath)));

        currentPath.Remove(root);
        currentValue -= root;
    }

    private static void AddEdge(Dictionary<int, List<int>> tree, int parent, int child)
    {
        if (!tree.ContainsKey(parent))
        {
            tree.Add(parent, new List<int>());
        }

        if (!tree.ContainsKey(child))
        {
            tree.Add(child, new List<int>());
        }

        tree[parent].Add(child);
    }
}