using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Google
{
    class ParentChild
    {
        private string name;
        private string birthDate;

        public ParentChild(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthDate}";
        }
    }
}
