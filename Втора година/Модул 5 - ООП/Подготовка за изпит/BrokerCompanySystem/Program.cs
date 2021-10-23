using System;
using BrokerCompanySystem.Core;

namespace BrokerCompanySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyController companyController = new CompanyController();

            Engine engine = new Engine(companyController);

            engine.Run();
        }
    }
}
