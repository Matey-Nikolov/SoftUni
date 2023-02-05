using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string accNumber = input[0];
            string owner = input[1] + " " + input[2];
            decimal balance = decimal.Parse(input[3]);


            var bankacc = new BankAccount(accNumber, owner, balance);

            string[] n = Console.ReadLine().Split(" ");

            while(n[0] != "End")
            {
                if(n[0] == "Deposit")
                {
                    bankacc.MakeDeposit(decimal.Parse(n[1]));
                }
                else if (n[0] == "Withdrawal")
                {
                    bankacc.MakeWithdrawal(decimal.Parse(n[1]));
                }
                n = Console.ReadLine().Split(" ");
            }
        }
    }
}
