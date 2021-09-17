using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Family
{
    class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }
    }
}