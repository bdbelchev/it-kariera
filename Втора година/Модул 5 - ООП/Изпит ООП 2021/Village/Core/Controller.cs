using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Controller
    {
        private List<Village> villages;
        private List<Rebel> rebels;
        private int attacks;

        public Controller()
        {
            villages = new List<Village>();
            rebels = new List<Rebel>();
            attacks = 0;
        }

        public string ProcessVillageCommand(List<string> args)
        {
            string name = args[0];
            string location = args[1];

            Village village = new Village(name, location);

            villages.Add(village);

            return $"Created Village {name}!";
        }

        public string ProcessSettleCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int productivity = int.Parse(args[2]);
            string villageName = args[3];

            Peasant peasant = new Peasant(name, age, productivity);

            Village village = GetVillage(villageName);
            village.AddPeasant(peasant);

            return $"Settled Peasant {name} in Village {villageName}!";
        }

        public string ProcessRebelCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int harm = int.Parse(args[2]);

            Rebel rebel = new Rebel(name, age, harm);

            rebels.Add(rebel);

            return $"Rebel {name} joined the gang!";
        }

        public string ProcessDayCommand(List<string> args)
        {
            string villageName = args[0];

            Village village = GetVillage(villageName);

            return $"Village {villageName} resource increased with {village.PassDay()}!";
        }

        public string ProcessAttackCommand(List<string> args)
        {
            if (rebels.Count < 1)
            {
                return "No rebels to perform raid...";
            }

            int rebelCount = int.Parse(args[0]);
            string villageName = args[1];

            List<Rebel> attackRebels = rebels.Take(rebelCount).ToList();
            int harmSum = attackRebels.Sum(r => r.Harm);

            Village village = GetVillage(villageName);
            village.Resource -= harmSum;
            int deadPeasants = village.KillPeasants(rebelCount / 2).Count;

            attacks++;

            return $"Village {villageName} lost {harmSum} resources and {deadPeasants} peasants!";
        }

        public string ProcessInfoCommand(List<string> args)
        {
            string side = args[0];

            StringBuilder sb = new StringBuilder();

            switch (side)
            {
                case "Village":
                    if (villages.Count < 1)
                    {
                        return "No Villages";
                    }

                    sb.AppendLine("Villages: ");
                    villages.ForEach(v => sb.AppendLine(v.ToString()));
                    break;
                case "Rebel":
                    if (rebels.Count < 1)
                    {
                        return "No Rebels";
                    }

                    sb.AppendLine("Rebels: ");
                    rebels.ForEach(r => sb.AppendLine(r.ToString()));
                    break;
            }

            return sb.ToString().Trim();
        }

        public string ProcessEndCommand()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Villages: {villages.Count}");
            sb.AppendLine($"Rebels: {rebels.Count}");
            sb.AppendLine($"Attacks on Villages: {attacks}");

            return sb.ToString().Trim();
        }

        private Village GetVillage(string name)
        {
            return villages.First(v => v.Name == name);
        }
    }
}