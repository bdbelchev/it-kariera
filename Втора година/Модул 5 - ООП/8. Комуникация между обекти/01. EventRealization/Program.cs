using System;

namespace _01._EventRealization
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string input = Console.ReadLine();

            while (input != "End")
            {
                dispatcher.Name = input;
                input = Console.ReadLine();
            }
        }
    }
}
