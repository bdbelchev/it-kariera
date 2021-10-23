using BrokerCompanySystem.Entities.Buildings;
using System;
using System.Collections.Generic;
using System.Text;


public class Broker
{
    private string name;
    private int age;
    private string city;
    private List<Building> buildings;

    public Broker(string name, int age, string city)
    {
        this.Name = name;
        this.Age = age;
        this.City = city;
        this.buildings = new List<Building>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Broker name must not be null or empty!");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 16 || value > 70)
            {
                throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
            }

            this.age = value;
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

    public double Bonus { get; private set; }

    public double ReceiveBonus(Building building)
    {
        double bonus = building.RentAmount * 2 * building.Stars / 100;
        this.Bonus += bonus;
        this.buildings.Add(building);
        return bonus;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"****Broker: {Name} <{Age}>");
        builder.AppendLine($"****Location: {City}");
        builder.AppendLine($"****Bonus: {Bonus}");
        buildings.ForEach(building => builder.AppendLine($"****** {building.Name}"));

        return builder.ToString().Trim();
    }
}

