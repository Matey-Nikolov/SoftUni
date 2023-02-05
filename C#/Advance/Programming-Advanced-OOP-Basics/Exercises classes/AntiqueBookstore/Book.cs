namespace AntiqueBookstore
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PubDate  { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public string Discount { get; set; }

        public Book(string title, string author, int pubDate, decimal price)
        {
            Title = title;
            Author = author;
            PubDate = pubDate;
            Price = price;
            Publisher = "Unknown";
            Discount = "Unavailable";
        }
        public Book(string title, string author, int pubDate, decimal price, string publisher)
        {
            Title = title;
            Author = author;
            PubDate = pubDate;
            Price = price;
            Publisher = publisher;
            Discount = "Unavailable";
        }

        public Book(string title, string author, int pubDate, decimal price, string publisher, string discount)
        {
            Title = title;
            Author = author;
            PubDate = pubDate;
            Price = price;
            Publisher = publisher;
            Discount = discount;
        }
    }
}