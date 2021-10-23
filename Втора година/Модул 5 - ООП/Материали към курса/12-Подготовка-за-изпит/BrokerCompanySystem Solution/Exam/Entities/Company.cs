using BrokerCompanySystem.Entities.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem.Entities
{
    public class Company
    {
        private string name;
        private List<Broker> brokers;
        private List<Building> buildings;

        public Company(string name)
        {
            this.Name = name;
            this.brokers = new List<Broker>();
            this.buildings = new List<Building>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddBroker(Broker broker)
        {
            Broker registeredBroker = this.GetBrokerByName(broker.Name);

            if (registeredBroker == null)
            {
                this.brokers.Add(broker);
            }
        }

        public void AddBuilding(Building building)
        {
            Building registeredBuilding = this.GetBuildingByName(building.Name);

            if (registeredBuilding == null)
            {
                this.buildings.Add(building);
            }
        }

        public Broker GetBrokerByName(string name)
        {
            return this.brokers.FirstOrDefault(broker => broker.Name == name);
        }

        public Building GetBuildingByName(string name)
        {
            return this.buildings.FirstOrDefault(building => building.Name == name);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Company: {Name}");

            builder.AppendLine($"##Brokers: {brokers.Count}");
            brokers.ForEach(broker => builder.AppendLine(broker.ToString()));

            builder.AppendLine($"##Buildings: {buildings.Count}");
            buildings.ForEach(building => builder.AppendLine(building.ToString()));


            return builder.ToString().Trim();
        }
    }
}
