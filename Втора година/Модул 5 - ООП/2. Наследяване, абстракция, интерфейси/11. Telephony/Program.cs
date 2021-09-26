using System;
using System.Linq;

namespace _11._Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone myPhone = new Smartphone();
            
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] urls = Console.ReadLine().Split().ToArray();

            foreach (string number in numbers)
            {
                myPhone.Call(number);
            }

            foreach (string url in urls)
            {
                myPhone.Connect(url);
            }
        }
    }
}
