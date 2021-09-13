using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DefinePersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Гошо";
            firstPerson.Age = 15;

            firstPerson.IntroduceYourself();
        }
    }
}
