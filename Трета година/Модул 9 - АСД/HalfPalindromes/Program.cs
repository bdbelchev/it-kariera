using System.Text;

static class Program
{
    public static void Main(string[] args)
    {
        char[] letters = Console.ReadLine().Split().Select(Convert.ToChar).ToArray();

        List<string> halfPals = new List<string>();

        Permute(letters, 0, new char[letters.Length], halfPals, new bool[letters.Length]);

        foreach (string halfPal in halfPals.OrderBy(x=>x))
        {
            Console.WriteLine(halfPal);
        }
    }

    private static void Permute(char[] letters, int index, char[] current, List<string> list, bool[] used)
    {
        if (index >= letters.Length)
        {
            string palindrome = string.Join(" ", current);

            if (!list.Contains(new string(palindrome.Reverse().ToArray())))
            {
                list.Add(palindrome);
            }
            return;
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                current[index] = letters[i];
                Permute(letters, index + 1, current, list, used);
                used[i] = false;
            }
        }
    }
}