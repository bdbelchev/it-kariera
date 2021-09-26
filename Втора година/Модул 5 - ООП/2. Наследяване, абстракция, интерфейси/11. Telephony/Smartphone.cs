using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._Telephony
{
    class Smartphone : ICallable, IConnectable
    {
        public void Call(string number)
        {
            Console.WriteLine(number.Any(char.IsLetter)
                ? "Invalid number!"
                : $"Calling... {number}");
        }

        public void Connect(string url)
        {
            Console.WriteLine(url.Any(char.IsDigit)
                ? "Invalid URL!"
                : $"Browsing: {url}!");
        }
    }
}
