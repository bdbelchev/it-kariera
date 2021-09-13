using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Shopping
{
    class Person
    {
        private string name;
        private int money;
        private List<Product> cart;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Cart = new List<Product>();
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

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Cart
        {
            get { return cart; }
            set { cart = value; }
        }

        public void AddToCart(Product product)
        {
            if (product.Price > this.Money)
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }

            this.Cart.Add(product);
            this.Money -= product.Price;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }

        public override string ToString()
        {
            return Cart.Count < 1 ? $"{this.Name} - Nothing bought" : $"{this.Name} - {string.Join(", ", this.Cart.Select(p => p.Name))}";
        }
    }
}
