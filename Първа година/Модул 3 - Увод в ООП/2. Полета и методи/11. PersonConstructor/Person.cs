using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.AddMethodsToBankAcc;

namespace _06.MoneyOfPerson
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person() : this(1) { }

        public Person(int age) : this("No name", age) { }

        public Person(string name, int age)
            : this(name, age, new List<BankAccount>())
        { }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
        }

        public double GetBalance()
        {
            return this.accounts.Sum(a => a.Balance);
        }
    }
}
