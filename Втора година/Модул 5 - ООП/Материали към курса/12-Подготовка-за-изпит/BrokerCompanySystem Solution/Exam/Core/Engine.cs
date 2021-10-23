using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem.Core
{
    public class Engine
    {
        private CompanyController companyController;
        private bool isRunning;

        public Engine(CompanyController companyController)
        {
            this.companyController = companyController;
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                List<string> args = Console.ReadLine()
                    .Split("*")
                    .ToList();

                string command = args[0];
                string result = null;
                args = args.Skip(1)
                    .ToList();

                try
                {
                    switch (command)
                    {
                        case "CreateCompany":
                            result = companyController.CreateCompany(args);
                            break;
                        case "RegisterBuilding":
                            result = companyController.RegisterBuilding(args);
                            break;
                        case "RegisterBroker":
                            result = companyController.RegisterBroker(args);
                            break;
                        case "RentBuilding":
                            result = companyController.RentBuilding(args);
                            break;
                        case "CompanyInfo":
                            result = companyController.CompanyInfo(args);
                            break;
                        case "Shutdown":
                            result = companyController.Shutdown();
                            this.isRunning = false;
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    result = ae.Message;
                }
                
                Console.WriteLine(result);
            }
        }
    }
}
