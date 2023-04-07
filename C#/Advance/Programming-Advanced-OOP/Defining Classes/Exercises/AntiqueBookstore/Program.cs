namespace AntiqueBookstore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = "";
            string author = "";
            int pubDate = 0;
            decimal price = 0;

            string publisher = "";
            string discount = "";

            while (input[0] != "End")
            {
                title = input[0];
                author = input[1];
                pubDate = int.Parse(input[2]);
                price = decimal.Parse(input[3]);

                

                if (input.Length == 4)
                {
                    Book book = new Book(title, author, pubDate, price);
                    books.Add(book);
                }
                else if (input.Length == 5)
                {
                    publisher = input[4];
                    Book book = new Book(title, author, pubDate, price, publisher);
                    books.Add(book);
                }
                else
                {
                    publisher = input[4];
                    discount = input[5];
                    Book book = new Book(title, author, pubDate, price, publisher, discount);
                    books.Add(book);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            books = books
                    .OrderBy(x => x.Author)
                    .ToList();

            foreach (var item in books)
            {
                Console.WriteLine($"Title : {item.Title}");
                Console.WriteLine($"   Author: {item.Author}");
                Console.WriteLine($"    Publication Date: {item.PubDate}");
                Console.WriteLine($"    Price: {item.Price}");
                Console.WriteLine($"    Publisher: {item.Publisher}");
                Console.WriteLine($"    Discount: {item.Discount}");
            }
        }
    }
}