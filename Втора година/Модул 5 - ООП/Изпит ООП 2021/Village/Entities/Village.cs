using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Village
{
    public class Village
    {
        private string name;
        private string location;
        private List<Peasant> peasants;

        public Village(string name, string location)
        {
            Name = name;
            Location = location;
            peasants = new List<Peasant>();
            Resource = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters!");
                }

                name = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            private set
            {
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("Location should be between 3 and 45 characters!");
                }

                location = value;
            }
        }

        public int Resource { get; set; }

        public void AddPeasant(Peasant peasant)
        {
            peasants.Add(peasant);
        }

        public int PassDay()
        {
            int newResources = peasants.Sum(p => p.Productivity);
            Resource += newResources;
            return newResources;
        }

        public List<Peasant> KillPeasants(int count)
        {
            List<Peasant> killedPeasants = new List<Peasant>();

            if (count >= peasants.Count)
            {
                killedPeasants = peasants;
                peasants.Clear();
                return killedPeasants;
            }

            killedPeasants = peasants.Take(count).ToList();
            peasants.RemoveRange(0, count);
            return killedPeasants;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Village - {Name} ({Location})");
            sb.AppendLine($"Resources - {Resource}");
            sb.AppendLine($"Peasants - ({peasants.Count})");
            peasants.ForEach(p => sb.AppendLine(p.ToString()));

            return sb.ToString().Trim();
        }
    }
}
