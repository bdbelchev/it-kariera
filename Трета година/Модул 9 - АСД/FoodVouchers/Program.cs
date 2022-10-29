namespace FoodVouchers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int neededValue = days * 20;
            int currentValue = 0;
            int count = 0;

            while (currentValue < neededValue)
            {
                if (currentValue + 100 > neededValue)
                {
                    currentValue += 20;
                    count++;

                }
                else
                {
                    currentValue += 100;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}