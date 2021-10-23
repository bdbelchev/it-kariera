using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private bool isRunning;
    private StoreController storeController;

    public Engine(StoreController storeController)
    {
        this.storeController = storeController;
        this.isRunning = true;
    }

    public void Run()
    {
        while (isRunning)
        {
            List<string> args = Console.ReadLine()
                .Split(":")
                .ToList();

            string commamd = args[0];

            args = args
                .Skip(1)
                .ToList();
            string result = "";

            try
            {
                switch (commamd)
                {
                    case "CreateStore":
                        result = this.storeController.CreateStore(args);
                        break;
                    case "ReceiveProduct":
                        result = this.storeController.ReceiveProduct(args);
                        break;
                    case "SellProduct":
                        result = this.storeController.SellProduct(args);
                        break;
                    case "StoreInfo":
                        result = this.storeController.StoreInfo(args);
                        break;
                    case "Shutdown":
                        isRunning = false;
                        result = this.storeController.Shutdown();
                        break;
                }
            }
            catch (ArgumentException argumentException)
            {
                result = argumentException.Message;
            }

            Console.WriteLine(result);
        }
    }
}