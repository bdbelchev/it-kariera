using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person();
            pesho.name = "Pesho";
            pesho.age = 20;

            Person gosho = new Person();
            gosho.name = "Gosho";
            gosho.age = 18;

            Person stamat = new Person();
            stamat.name = "Stamat";
            stamat.age = 43;
        }
    }
}
