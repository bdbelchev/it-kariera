using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Google
{
    class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<ParentChild> parents;
        private List<ParentChild> children;

        public Person(string name)
        {
            this.name = name;
            this.pokemons = new List<Pokemon>();
            this.parents = new List<ParentChild>();
            this.children = new List<ParentChild>();
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public List<ParentChild> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public List<ParentChild> Children
        {
            get { return children; }
            set { children = value; }
        }

        public override string ToString()
        {
            return this.name + "\n" +
                   $"Company: \n{this.Company}" + "\n" +
                   $"Car: \n{this.Car}" + "\n" +
                   $"Pokemon: \n{string.Join("\n", this.Pokemons.ConvertAll(p => p.ToString()))}" + "\n" +
                   $"Parents: \n{string.Join("\n", this.Parents.ConvertAll(p => p.ToString()))}" + "\n" +
                   $"Children: \n{string.Join("\n", this.Children.ConvertAll(c => c.ToString()))}";
        }
    }
}
