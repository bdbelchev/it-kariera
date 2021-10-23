using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Store
{
    private string name;
    private string type;
    private List<Product> products;

    public Store(string name, string type)
    {
        Name = name;
        Type = type;
        Revenue = 0;

        products = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Store name must not be null or empty!");
            }

            name = value;
        }
    }
    public string Type
    {
        get { return type; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Store type must not be null or empty!");
            }

            type = value;
        }
    }

    public double Revenue { get; private set; }

    public bool ReceiveProduct(Product product)
    {
        if (GetProduct(product.Name) == null)
        {
            products.Add(product);
            return true;
        }

        return false;
    }

    public bool SellProduct(string name, int quantity)
    {
        Product product = GetProduct(name);

        if (product == null || quantity > product.Quantity)
        {
            return false;
        }

        if (quantity == product.Quantity)
        {
            products.Remove(product);
        }
        else
        {
            product.Quantity -= quantity;
        }

        Revenue += product.FinalPrice * quantity;
        return true;
    }

    public Product GetProduct(string name)
    {
        return products.FirstOrDefault(p => p.Name == name);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"****Store: {Name} <{Type}>");
        sb.AppendLine($"****Available products: <{products.Count}>");
        products.ForEach(p => sb.AppendLine($"****** {p.Name} ({p.Quantity})"));
        sb.AppendLine($"****Revenue: <{Revenue:F2}BGN>");

        return sb.ToString().Trim();
    }
}