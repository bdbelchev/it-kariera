using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PokemonTrainer
{
    class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Element
        {
            get { return element; }
        }
    }
}
