using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokerCompanySystem.Entities;
using BrokerCompanySystem.Entities.Buildings;

namespace BrokerCompanySystem.Core
{
    public class CompanyController
    {
        private List<Company> companies;

        public CompanyController()
        {
            companies = new List<Company>();
        }

        private Company GetCompanyByName(string name)
        {
            return companies.FirstOrDefault(c => c.Name == name);
        }

        public string CreateCompany(List<string> args)
        {
            string name = args[0];

            if (GetCompanyByName(name) == null)
            {
                companies.Add(new Company(name));

                return $"Company {name} was successfully registered in the system!";
            }
            else
            {
                return $"Company {name} is already registered!";
            }
        }

        public string RegisterBuilding(List<string> args)
        {
            string type = args[0];
            string name = args[1];
            string city = args[2];
            int stars = int.Parse(args[3]);
            double rentAmount = double.Parse(args[4]);
            string companyName = args[5];

            Company company = GetCompanyByName(companyName);

            if (company == null)
            {
                return $"Invalid Company:  {companyName}. Cannot find it in system!";
            }

            Building building = company.GetBuildingByName(name);

            if (building != null)
            {
                return $"Building {name} is already registered in {companyName}!";
            }

            switch (type)
            {
                case "Hotel":
                    building = new Hotel(name, city, stars, rentAmount);
                    break;
                case "Residence":
                    building = new Residence(name, city, stars, rentAmount);
                    break;
                case "Business":
                    building = new Business(name, city, stars, rentAmount);
                    break;
            }

            company.AddBuilding(building);

            return $"Building {name} was successfully registered in {companyName} catalog!";
        }

        public string RegisterBroker(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            string city = args[2];
            string companyName = args[3];

            Company company = GetCompanyByName(companyName);

            if (company == null)
            {
                return $"Invalid Company:  {companyName}. Cannot find it in system!";
            }

            Broker broker = company.GetBrokerByName(name);

            if (broker != null)
            {
                return $"Broker {name} is already part of {companyName}!";
            }

            broker = new Broker(name, age, city);
            company.AddBroker(broker);

            return $"Broker {name} was successfully hired in {companyName}!";
        }

        public string RentBuilding(List<string> args)
        {
            string companyName = args[0];
            string buildingName = args[1];
            string brokerName = args[2];

            Company company = GetCompanyByName(companyName);

            if (company == null)
            {
                return $"Invalid Company:  {companyName}. Cannot find it in system!";
            }

            Building building = company.GetBuildingByName(buildingName);

            if (building == null)
            {
                return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            }

            if (building.IsAvailable == false)
            {
                return $"Building: {buildingName} cannot be rented!";
            }

            Broker broker = company.GetBrokerByName(brokerName);

            if (broker == null)
            {
                return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
            }

            double bonus = broker.ReceiveBonus(building);

            return $"Successfully rented {buildingName}!"
                   + Environment.NewLine
                   + $"Broker {brokerName} earned {bonus}!";
        }

        public string CompanyInfo(List<string> args)
        {
            string companyName = args[0];

            Company company = GetCompanyByName(companyName);

            return company == null ? $"Invalid Company: {companyName}. Cannot find it in system!" : company.ToString();
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Companies: {companies.Count}");
            companies.OrderBy(c => c.Name).ToList().ForEach(c => sb.AppendLine(c.ToString()));

            return sb.ToString().Trim();
        }
    }
}
