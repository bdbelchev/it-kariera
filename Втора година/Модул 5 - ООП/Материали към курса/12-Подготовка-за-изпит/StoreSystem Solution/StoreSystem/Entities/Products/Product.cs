using System;
using System.Collections.Generic;
using System.Text;

public abstract class Product
{
    private string name;
    private int quantity;
    private double deliverPrice;
    private double percentageMarkup;

    protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
    {
        this.Name = name;
        this.Quantity = quantity;
        this.DeliverPrice = deliverPrice;
        this.PercentageMarkup = percentageMarkup;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Product name must not be null or empty!");
            }

            this.name = value;
        }
    }

    public int Quantity
    {
        get { return this.quantity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Quantity cannot be less or equal to 0!");
            }

            this.quantity = value;
        }
    }

    public double DeliverPrice
    {
        get { return this.deliverPrice; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deliver price cannot be less or equal to 0!");
            }

            this.deliverPrice = value;
        }
    }
    public virtual double PercentageMarkup
    {
        get { return this.percentageMarkup; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
            }

            this.percentageMarkup = value;
        }
    }

    public double FinalPrice
    {
        get
        {
            return DeliverPrice + (DeliverPrice * PercentageMarkup / 100);
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"****Product: {Name} <{Quantity}>");
        builder.AppendLine($"****Deliver Price: {DeliverPrice}");
        builder.AppendLine($"****Percentage Markup: {PercentageMarkup}");
        builder.AppendLine($"****Final Price: {FinalPrice}");

        return builder.ToString().Trim();
    }

}
