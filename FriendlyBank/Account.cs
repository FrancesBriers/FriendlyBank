using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FriendlyBank
{
    class Account
    {
        //Fields
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        private decimal Balance = 0;
        public int Overdraft;

        public static void PrintAccount(Account a)
        {
            WriteLine("Name: " + a.Name);
            WriteLine("Address: " + a.Address);
        }

        public bool WithdrawFunds (decimal amount)
        {
            if (Balance < amount)
            {
                return false;
            }
            Balance = Balance - amount;
            return true;
        }
        public enum AccountState
        {
            New,
            Active,
            UnderAudit,
            Frozen,
            Closed
        };

    }
}
