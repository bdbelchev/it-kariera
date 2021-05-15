using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shop
{
    class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;

        public Product(string barcode, string name, double price, double quantity)
        {
            this.barcode = barcode;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public double TotalPrice
        {
            get { return price * quantity; }
        }

        public override string ToString()
        {
            return $"{name} ({barcode})";
        }
    }
}
