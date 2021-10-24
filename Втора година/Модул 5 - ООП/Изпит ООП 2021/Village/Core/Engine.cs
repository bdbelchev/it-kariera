using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Engine
    {
        private bool isRunning;
        private Controller controller;
        private string result;

        public Engine(Controller controller)
        {
            this.controller = controller;
            isRunning = true;
            result = "";
        }

        public void Run()
        {
            while (isRunning)
            {
                List<string> args = Console.ReadLine().Split().ToList();
                string command = args[0];
                args = args.Skip(1).ToList();

                try
                {
                    switch (command)
                    {
                        case "Village":
                            result = controller.ProcessVillageCommand(args);
                            break;
                        case "Settle":
                            result = controller.ProcessSettleCommand(args);
                            break;
                        case "Rebel":
                            result = controller.ProcessRebelCommand(args);
                            break;
                        case "Day":
                            result = controller.ProcessDayCommand(args);
                            break;
                        case "Attack":
                            result = controller.ProcessAttackCommand(args);
                            break;
                        case "Info":
                            result = controller.ProcessInfoCommand(args);
                            break;
                        case "End":
                            isRunning = false;
                            result = controller.ProcessEndCommand();
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
}
