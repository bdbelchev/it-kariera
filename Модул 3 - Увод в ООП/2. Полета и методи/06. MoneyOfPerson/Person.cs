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

        public double GetBalance()
        {
            return this.accounts.Sum(a => a.Balance);
        }
    }
}
