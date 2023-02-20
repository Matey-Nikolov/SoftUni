namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static List<Person> people = new List<Person>();
        public static List<Product> products = new List<Product>();
        static void Main()
        {
            string[] allPeople = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            AddPeople(allPeople);

            string[] allProducts = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            AddProduts(allProducts);

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string namePerson = input[0];
                string nameProduct = input[1];


                foreach (var person in people)
                {
                    if (person.Name == namePerson)
                    {
                        foreach (var itemProduct in products)
                        {
                            if (itemProduct.Name == nameProduct)
                            {
                                if (person.Money >= itemProduct.Money)
                                {
                                    person.Money -= itemProduct.Money;
                                    person.BagOfProduts.Add(itemProduct);
                                    Console.WriteLine($"{person.Name} bought {itemProduct.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {itemProduct.Name}");
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var personProduct in people)
            {
                sb.Clear();

                foreach (var product in personProduct.BagOfProduts)
                {
                    sb.Append(product.Name + ", ");
                }

                if (sb.Length > 0)
                {
                    sb = sb.Remove(sb.Length - 2, 1);
                    Console.WriteLine($"{personProduct.Name} - {sb}");
                }
                else
                {
                    Console.WriteLine($"{personProduct.Name} - Nothing bought");
                }
            }
        }
        public static void AddProduts(string[] allProducts)
        {
            for (int i = 0; i < allProducts.Length; i++)
            {
                string[] splitPeople = allProducts[i].Split('=');

                string nameProduct = splitPeople[0];
                decimal moneyProduct = decimal.Parse(splitPeople[1]);

                Product product = new Product(nameProduct, moneyProduct);

                products.Add(product);
            }
        }
        public static void AddPeople(string[] allPeople)
        {
            for (int i = 0; i < allPeople.Length; i++)
            {
                string[] splitPeople = allPeople[i].Split('=');

                string name = splitPeople[0];
                decimal money = decimal.Parse(splitPeople[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }
        }
    }
}