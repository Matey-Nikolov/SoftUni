namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Person
    {
        private decimal money;
        public string Name { get; set; }
        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<Product> BagOfProduts { get; set; }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProduts = new List<Product>();
        }
    }
}