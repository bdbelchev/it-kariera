using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private bool isRunning;
    private StoreController controller;

    public Engine(StoreController controller)
    {
        isRunning = true;
        this.controller = controller;
    }

    public void Run()
    {
        while (isRunning)
        {
            List<string> args = Console.ReadLine().Split(':').ToList();
            string command = args[0];
            args = args.Skip(1).ToList();

            string result = null;

            try
            {
                switch (command)
                {
                    case "CreateStore":
                        result = controller.CreateStore(args);
                        break;
                    case "ReceiveProduct":
                        result = controller.ReceiveProduct(args);
                        break;
                    case "SellProduct":
                        result = controller.SellProduct(args);
                        break;
                    case "StoreInfo":
                        result = controller.StoreInfo(args);
                        break;
                    case "Shutdown":
                        isRunning = false;
                        result = controller.Shutdown();
                        break;
                }
            }
            catch (ArgumentException e)
            {
                result = e.Message;
            }

            Console.WriteLine(result);
        }
    }
}
