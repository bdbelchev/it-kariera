using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int badgeCount;
        private List<Pokemon> collection;

        public Trainer(string name)
        {
            this.name = name;
            this.badgeCount = 0;
            this.collection = new List<Pokemon>();
        }

        public string Name
        {
            get { return name; }
        }

        public int BadgeCount
        {
            get { return badgeCount; }
            set { badgeCount = value; }
        }

        public List<Pokemon> Collection
        {
            get { return collection; }
        }

        public void CheckHealth()
        {
            List<Pokemon> deadPokemons = Collection.Where(p => p.Health <= 0).ToList();

            foreach (var pokemon in deadPokemons)
            {
                collection.Remove(pokemon);
            }
        }
    }
}
