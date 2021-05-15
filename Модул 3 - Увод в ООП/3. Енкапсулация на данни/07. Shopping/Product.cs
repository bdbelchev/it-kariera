using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Shopping
{
    class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }

                this.price = value;
            }
        }
    }
}
