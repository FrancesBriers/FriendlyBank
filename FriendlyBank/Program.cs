using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FriendlyBank
{
    class Program
    {
      
        public static void Main()
        {
            const int Max_Cust = 100;
            Account[] Bank = new Account[Max_Cust];

            Account TimsAccount = new Account();
            TimsAccount.Name = "Tim";
            if (TimsAccount.WithdrawFunds (4))
            {
                WriteLine("Cash Withdrawn");
            }
            else
            {
                WriteLine("Insufficient Funds");
            }
            WriteLine(TimsAccount.Name);
            Read();
        }
    }
}
