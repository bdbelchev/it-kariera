using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem.Entities.Buildings
{
    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;

        protected Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
            this.IsAvailable = true;
        }

        public virtual string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public string City
        {
            get { return this.city; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }

                this.city = value;
            }
        }

        public int Stars
        {
            get { return this.stars; }
            private set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }

                this.stars = value;
            }
        }

        public double RentAmount
        {
            get { return this.rentAmount; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }

                this.rentAmount = value;
            }
        }

        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"****Building: {Name} <{Stars}>");
            builder.AppendLine($"****Location: {City}");
            builder.AppendLine($"****RentAmount: {RentAmount}");
            builder.AppendLine($"****Is Available: {IsAvailable}");

            return builder.ToString().Trim();
        }
    }
}
