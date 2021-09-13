using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OldestFamilyMember
{
    class Family
    {
        private List<Person> members;

        public void AddMember(Person member)
        {
            if (members == null)
            {
                members = new List<Person>();
            }

            members.Add(member);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(m => m.Age).First();
        }
    }
}
