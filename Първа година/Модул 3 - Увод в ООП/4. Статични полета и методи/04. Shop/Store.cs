using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shop
{
    static class Store
    {
        private static Dictionary<string, Product> inventory;

        static Store()
        {
            inventory = new Dictionary<string, Product>();
        }

        public static void Sell(string[] cmdArgs)
        {
            string barcode = cmdArgs[1];
            double quantity = double.Parse(cmdArgs[2]);

            if (!inventory.ContainsKey(barcode) || quantity > inventory[barcode].Quantity)
            {
                throw new ArgumentException("Not enough quantity");
            }

            inventory[barcode].Quantity -= quantity;
        }

        public static void Add(string[] cmdArgs)
        {
            string barcode = cmdArgs[1];
            string name = cmdArgs[2];
            double price = double.Parse(cmdArgs[3]);
            double quantity = double.Parse(cmdArgs[4]);

            if (inventory.ContainsKey(barcode))
            {
                throw new ArgumentException("Product exists.");
            }

            Product product = new Product(barcode, name, price, quantity);
            inventory.Add(barcode, product);
        }

        public static void Update(string[] cmdArgs)
        {
            string barcode = cmdArgs[1];
            double quantity = double.Parse(cmdArgs[2]);

            if (!inventory.ContainsKey(barcode))
            {
                throw new ArgumentException("Please add your product first!");
            }

            inventory[barcode].Quantity += quantity;
        }

        public static string Print(string[] cmdArgs)
        {
            StringBuilder sb = new StringBuilder();

            switch (cmdArgs[0])
            {
                case "PrintA":
                    foreach (var product in inventory.Values.Where(p => p.Quantity > 0).OrderBy(p => p.Name))
                    {
                        sb.Append(product).AppendLine();
                    }
                    break;
                case "PrintD":
                    foreach (var product in inventory.Values.OrderByDescending(p => p.Quantity))
                    {
                        sb.Append(product).AppendLine();
                    }
                    break;
                case "PrintU":
                    foreach (var product in inventory.Values.Where(p => p.Quantity < 0))
                    {
                        sb.Append(product).AppendLine();
                    }
                    break;
            }

            return sb.ToString();
        }

        public static double Calculate()
        {
            return inventory.Values.Sum(p => p.TotalPrice);
        }
    }
}
