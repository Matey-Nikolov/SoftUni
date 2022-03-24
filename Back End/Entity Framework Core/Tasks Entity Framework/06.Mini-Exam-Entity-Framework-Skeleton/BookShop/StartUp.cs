namespace BookShop
{
    using Data;
    using System;
    using System.Linq;
    using System.Text;
    using BookShop.Models;

    public class StartUp
    {
        public static void Main()
        {
            using BookShopContext db = new BookShopContext();

            //1
            //Console.WriteLine(GetBooksFullInformation(db));

            // 2
            //Console.WriteLine(FilterDataByPrice(db));

            //3
            //string filter = Console.ReadLine();
            //Console.WriteLine(FilterDataByAuthor(db, filter));

            //4
            int findAndChange = int.Parse(Console.ReadLine());
            Console.WriteLine(ChangeDescription(db, findAndChange));
        }

        //In the project “BookShop.Data” click on “Configuration.cs” 
        //Check if the server name in the path is the same like in Microsoft SQL Management Studio. 
        //If it's not, change it.

        // Get Books Full Information
        public static string GetBooksFullInformation(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var booksFullInformation = context.Books
                .Select(x => new {x.BookId, x.Title, x.Description, x.Price, x.Author.FirstName, x.Author.LastName})
                .OrderBy(y => y.BookId)
                .ToList();


            foreach (var information in booksFullInformation)
            {
                sb.Append($"ID:{information.BookId}");
                sb.Append($" Title:{information.Title}");
                sb.Append($" Description:{information.Description}");
                sb.Append($" Price:{information.Price:f2}");
                sb.Append($" Author:{information.FirstName}");
                sb.Append($" Author:{information.LastName} \n \n");
            }
            return sb.ToString().Trim();
        }

        // Filter Data by Price
        public static string FilterDataByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var filterDataByPrice = context.Books
                .Where(x => x.Price >= 25)
                .OrderByDescending(y => y.Price)
                .ToList();

            foreach (var item in filterDataByPrice)
            {
                sb.Append($"{item.Title} - {item.Price} \n");
            }

            return sb.ToString().TrimEnd();
        }

        // Filter Data by Author
        public static string FilterDataByAuthor(BookShopContext context, string input)
        {

            var sb = new StringBuilder();

            var FilterDataByAuthor = context.Books
                .Where(z => z.Author.LastName.StartsWith(input.ToUpper()))
                .Select(x => new {x.BookId, x.Title, x.Author.FirstName, x.Author.LastName }) 
                .OrderBy(y => y.BookId)
                .ToList();

            foreach (var item in FilterDataByAuthor)
            {
                sb.Append($"{item.Title} ({item.FirstName} {item.LastName}) \n");
            }

            return sb.ToString().TrimEnd();
        }

        // Change Description
        public static string ChangeDescription(BookShopContext context, int id)
        {
            StringBuilder sb = new StringBuilder();

            var change = context.Books.Where(x => x.BookId == id).ToList();
            change.FirstOrDefault().Description = "The description was changed.";
            context.SaveChanges();

            var changeDescription = context.Books
                .Select(x => new { x.BookId, x.Title, x.Description, x.Price, x.Author.FirstName, x.Author.LastName })
                .OrderBy(x => x.BookId)
                .ToList();



            foreach (var information in changeDescription)
            {
                sb.Append($"ID:{information.BookId}");
                sb.Append($" Title:{information.Title}");
                sb.Append($" Description:{information.Description}");
                sb.Append($" Price:{information.Price:f2}");
                sb.Append($" Author:{information.FirstName}");
                sb.Append($" Author:{information.LastName} \n \n");
            }

            return sb.ToString().Trim();
        }

    }
}
