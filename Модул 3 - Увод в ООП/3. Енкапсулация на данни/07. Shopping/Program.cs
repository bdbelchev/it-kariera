using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> customers = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            PopulateDictionary(customers);
            PopulateDictionary(products);

            ProcessPurchases(customers, products);

            PrintPurchases(customers);
        }

        private static void PrintPurchases(Dictionary<string, Person> customers)
        {
            foreach (var customer in customers.Values)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        private static void ProcessPurchases(Dictionary<string, Person> customers, Dictionary<string, Product> products)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmdArgs = input.Split();

                try
                {
                    customers[cmdArgs[0]].AddToCart(products[cmdArgs[1]]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
        }

        private static void PopulateDictionary(Dictionary<string, Product> dict)
        {
            string[] input = Console.ReadLine().Split(';');

            foreach (string command in input)
            {
                string[] cmdArgs = command.Split('=');
                string name = cmdArgs[0];
                int value = int.Parse(cmdArgs[1]);

                Product product = new Product(name, value);
                dict.Add(name, product);
            }
        }

        private static void PopulateDictionary(Dictionary<string, Person> dict)
        {
            string[] input = Console.ReadLine().Split(';');

            foreach (string command in input)
            {
                string[] cmdArgs = command.Split('=');
                string name = cmdArgs[0];
                int value = int.Parse(cmdArgs[1]);

                Person person = new Person(name, value);
                dict.Add(name, person);
            }
        }
    }
}
