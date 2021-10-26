using System;

namespace _05._UniversalScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> testScale = new Scale<int>(96, 96);
            Console.WriteLine(testScale.getHeavier());
        }
    }
}
