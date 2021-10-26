using System;

namespace _02._BoxForEverything
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                Console.WriteLine(int.TryParse(data, out int result)
                    ? new Box<int>(result).ToString()
                    : new Box<string>(data).ToString());
            }
        }
    }
}
