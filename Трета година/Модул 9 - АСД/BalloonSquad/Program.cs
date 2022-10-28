static class Program
{
    private static int count = 0;

    public static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int balloonCount = int.Parse(Console.ReadLine());

        int[,] matrix = new int[dimensions[0], dimensions[1]];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
            }
        }

        PutBalloon(matrix, 0, balloonCount, 0);
        Console.WriteLine(count);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    private static void PutBalloon(int[,] matrix, int row, int needed, int currentCount)
    {
        if (row >= matrix.GetLength(0))
        {
            count++;
            return;
        }

        if (currentCount>needed)
        {
            return;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col] == 0)
            {
                MarkBalloon(matrix, row, col);
                PutBalloon(matrix, row + 1, needed, currentCount+1);
                UnmarkBalloon(matrix, row, col);
            }
        }
    }

    private static void UnmarkBalloon(int[,] matrix, int row, int col)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[row, i]--;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, col]--;
        }

        matrix[row, col] = 0;
    }

    private static void MarkBalloon(int[,] matrix, int row, int col)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[row, i]++;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, col]++;
        }

        matrix[row, col] = -1;
    }
}