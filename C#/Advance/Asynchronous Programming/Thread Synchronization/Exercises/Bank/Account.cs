namespace Bank
{
    public class Account
    {
        private int Balance {  get; set; }
        private readonly object balanceLock = new object();

        public Account(int balance)
        {
            Balance = balance;
        }

        public int Withdraw(int amount)
        {
            lock (balanceLock)
            {
                try
                {
                    if (Balance < 0)
                    {
                        throw new ArgumentOutOfRangeException("Negative Balance");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                if (Balance >= amount)
                {
                    Console.WriteLine($"Balance before Withdrawal: {Balance}");
                    Console.WriteLine($"Amount to Withdraw: -{amount}");

                    Balance -= amount;

                    Console.WriteLine($"Balance after Withdrawal: {Balance}");
                }
                else
                {
                    return 0;
                }

                return amount;
            }

        }
    }
}
