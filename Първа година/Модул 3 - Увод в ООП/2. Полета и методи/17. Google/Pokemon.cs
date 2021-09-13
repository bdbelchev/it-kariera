using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _17.Google
{
    class Pokemon
    {
        private string name;
        private string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return $"{this.name} {this.type}";
        }
    }
}
