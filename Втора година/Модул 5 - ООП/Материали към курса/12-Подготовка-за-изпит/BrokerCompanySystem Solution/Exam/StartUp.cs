using BrokerCompanySystem.Core;

public class StartUp
{
    public static void Main(string[] args)
    {
        CompanyController companyController = new CompanyController();
        Engine engine = new Engine(companyController);

        engine.Run();
    }
}
