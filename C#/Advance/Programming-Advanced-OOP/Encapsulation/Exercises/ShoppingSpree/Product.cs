namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Product
    {
        private string name;
        private decimal money;

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value <= -1)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public Product(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

    }
}