static class Program
{
    static void Main(string[] args)
    {
        int[] vector = new int[3];
        GenerateVectors(0, vector);
    }

    private static void GenerateVectors(int index, int[] vector)
    {
        if (index >= vector.Length)
        {
            Console.WriteLine(String.Join(" ", vector));
        }
        else
        {
            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                GenerateVectors(index + 1, vector);
            }
        }
    }
}