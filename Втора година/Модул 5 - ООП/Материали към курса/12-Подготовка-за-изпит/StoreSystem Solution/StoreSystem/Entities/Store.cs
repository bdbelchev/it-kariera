using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Store
{
    private string name;
    private string type;
    private List<Product> products;

    public Store(string name, string type)
    {
        this.Name = name;
        this.Type = type;
        this.products = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Store name must not be null or empty!");
            }

            this.name = value;
        }
    }

    public string Type
    {
        get { return this.type; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Store type must not be null or empty!");
            }

            this.type = value;
        }
    }

    public double Revenue { get; private set; }

    public bool ReceiveProduct(Product product)
    {
        Product storeProduct = GetProduct(product.Name);

        if (storeProduct == null)
        {
            this.products.Add(product);
            return true;
        }

        return false;
    }

    public bool SellProduct(string name, int quantity)
    {
        Product storeProduct = GetProduct(name);

        if (storeProduct == null || storeProduct.Quantity < quantity)
        {
            return false;
        }

        if (storeProduct.Quantity == quantity)
        {
            this.products.Remove(storeProduct);
        }
        else
        {
            storeProduct.Quantity -= quantity;
        }

        this.Revenue += quantity * storeProduct.FinalPrice;

        return true;
    }

    public Product GetProduct(string name)
    {
        return products
          .FirstOrDefault(storeProduct => storeProduct.Name == name);
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"****Store: {Name} <{Type}>");
        builder.AppendLine($"****Available products: <{products.Count}>");
        products.ForEach(product => builder.AppendLine($"****** {product.Name} ({product.Quantity})"));
        builder.AppendLine($"****Revenue: <{Revenue:F2}BGN>");

        return builder.ToString().Trim();
    }
}
