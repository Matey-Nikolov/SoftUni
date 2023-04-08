namespace BankAccountsCustomers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal AccountBalance { get; set; }

        public BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            AccountBalance = balance;
        }
        public void MakeDeposit(decimal amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"Account balance: {AccountBalance}");
        }

        public void MakeWithdrawal(decimal amount)
        {
            if (amount < AccountBalance)
            {
                Console.WriteLine("Non-Sufficient Funds");
            }
            else
            {
                decimal fundsAvailable = AccountBalance - amount;
                AccountBalance = fundsAvailable;
                Console.WriteLine($"Withdrawn funds: {amount}. Funds available on the account: {fundsAvailable}");
            }
        }
    }
}