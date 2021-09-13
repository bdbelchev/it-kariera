using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Banker
{
    static class Bank
    {
        private static Dictionary<int, BankAccount> bankAccounts;

        static Bank()
        {
            bankAccounts = new Dictionary<int, BankAccount>();
        }

        public static void WithdrawFunds(int id, double amount)
        {
            CheckID(id);
            bankAccounts[id].Withdraw(amount);
        }

        public static void DepositFunds(int id, double amount)
        {
            CheckID(id);
            bankAccounts[id].Deposit(amount);
        }

        private static void CheckID(int id)
        {
            if (!bankAccounts.ContainsKey(id))
            {
                throw new ArgumentException("Bank account does not exist!");
            }
        }
    }
}
