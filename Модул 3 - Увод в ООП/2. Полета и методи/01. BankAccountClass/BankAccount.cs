using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BankAccountClass
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }
    }
}
