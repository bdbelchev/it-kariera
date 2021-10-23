using BrokerCompanySystem.Entities;
using BrokerCompanySystem.Entities.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CompanyController
{
    private const string MissingCompanyMessage = "Invalid Company: {0}. Cannot find it in system!";
    private List<Company> companies;

    public CompanyController()
    {
        this.companies = new List<Company>();
    }

    public string CreateCompany(List<string> args)
    {
        string name = args[0];
        Company company = GetCompanyByName(name);

        if (company != null)
        {
            return $"Company {name} is already registered!";
        }

        company = new Company(name);
        this.companies.Add(company);

        return $"Company {name} was successfully registerd in the system!";
    }

    public string RegisterBuilding(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        string city = args[2];
        int stars = int.Parse(args[3]);
        double rentAmount = double.Parse(args[4]);
        string companyName = args[5];

        Company company = this.GetCompanyByName(companyName);

        if (company == null)
        {
            return string.Format(MissingCompanyMessage, companyName); ;
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

        return $"Building {name} was successfully registerd in {companyName} catalog!";
    }

    public string RegisterBroker(List<string> args)
    {
        string name = args[0];
        int age = int.Parse(args[1]);
        string city = args[2];
        string companyName = args[3];

        Company company = this.GetCompanyByName(companyName);

        if (company == null)
        {
            return string.Format(MissingCompanyMessage, companyName); ;
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
            return string.Format(MissingCompanyMessage, companyName);
        }

        Building building = company.GetBuildingByName(buildingName);
        if (building == null)
        {
            return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
        }

        if (!building.IsAvailable)
        {
            return $"Building: {buildingName} cannot be rented!";
        }

        Broker broker = company.GetBrokerByName(brokerName);
        if (broker == null)
        {
            return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
        }

        building.IsAvailable = false;
        double bonus = broker.ReceiveBonus(building);

        return $"Successfully rented {buildingName}!{Environment.NewLine}Broker {brokerName} earned {bonus}!";
    }

    public string CompanyInfo(List<string> args)
    {
        string companyName = args[0];
        Company company = this.GetCompanyByName(companyName);
        if (company == null)
        {
            return string.Format(MissingCompanyMessage, companyName);
        }

        return company.ToString();
    }

    public string Shutdown()
    {
        StringBuilder builder = new StringBuilder();

        List<Company> sortedCompanies = companies
            .OrderBy(company => company.Name)
            .ToList();

        builder.AppendLine($"Companies: {companies.Count}");
        sortedCompanies.ForEach(company => builder.AppendLine(company.ToString()));

        return builder.ToString().Trim();
    }

    private Company GetCompanyByName(string name)
    {
        return this.companies.FirstOrDefault(company => company.Name == name);
    }

}