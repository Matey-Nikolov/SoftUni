using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }

        public decimal AccountBalance { get; set; }

        public BankAccount(string accountNumber, string ownerName, decimal accountBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            AccountBalance = accountBalance;
        }

        public void MakeDeposit(decimal amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"Account balance: { AccountBalance }");
        }

        public void MakeWithdrawal(decimal draw)
        {
            if(draw > AccountBalance)
            {
                Console.WriteLine("Non-Sufficient Funds");
            }
            else
            {
                AccountBalance -= draw;
                Console.WriteLine($"Withdrawn funds: { draw}. Funds available on the account: { AccountBalance }");
            }
        }


    }
}
