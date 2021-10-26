using System;

namespace _03._ArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator<string>.Create(5, "Pesho");
            int[] ints = ArrayCreator<int>.Create(10, 33);
        }
    }
}
