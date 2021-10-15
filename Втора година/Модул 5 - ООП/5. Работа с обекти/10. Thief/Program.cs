using System;

namespace _10._Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            //Условие 1
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);

            //Условие 2
            result = spy.AnalyzeAccessModifiers("Hacker");
            Console.WriteLine(result);

            //Условие 3
            result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result);

            //Условие 4
            result = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(result);
        }
    }
}
