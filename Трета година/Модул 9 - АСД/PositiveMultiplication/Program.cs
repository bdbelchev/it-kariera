namespace PositiveMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.WriteLine(Multiply(numbers[0], numbers[1]));
        }

        private static int Multiply(int n1, int n2)
        {
            if (n2 == 1)
            {
                return n1;
            }

            return Multiply(n1, n2 - 1) + n1;
        }
    }
}