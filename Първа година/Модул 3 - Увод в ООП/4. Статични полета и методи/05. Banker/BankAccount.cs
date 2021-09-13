using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Banker
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentException("Insufficient balance!");
            }

            balance -= amount;
        }

        public override string ToString()
        {
            return $"Bank account {id} has a balance of {balance:f2}";
        }
    }
}
