using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "Close")
            {
                var cmdArgs = command.Split();

                string action = cmdArgs[0];

                switch (action)
                {
                    case "Sell":
                        try
                        {
                            Store.Sell(cmdArgs);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "Update":
                        try
                        {
                            Store.Update(cmdArgs);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "Add":
                        try
                        {
                            Store.Add(cmdArgs);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "Calculate":
                        Console.WriteLine($"{Store.Calculate():f2}");
                        break;
                    default:
                    {
                        if (action.StartsWith("Print"))
                        {
                            Console.Write(Store.Print(cmdArgs));
                        }

                        break;
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
