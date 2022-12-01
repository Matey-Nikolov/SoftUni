namespace ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using ProductShop.Data;
    using ProductShop.Models;
    public class StartUp
    {
        public static void Main()
        {



            // ADD DATABASE
            ProductShopContext dbContext = new ProductShopContext();




            // Import Users
            //string path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\ProductShopProject\\ProductShop\\Datasets\\users.json";
            //Console.WriteLine(ImportUsers(dbContext, parth));

            // Import Products
            //string path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\ProductShopProject\\ProductShop\\Datasets\\products.json";
            //Console.WriteLine(ImportProducts(dbContext, parth));

            //Import Categories
            //string path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\ProductShopProject\\ProductShop\\Datasets\\categories.json";
            //Console.WriteLine(ImportCategories(dbContext, parth));

            //Import Categories
            //string path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\ProductShopProject\\ProductShop\\Datasets\\categories-products.json";
            //Console.WriteLine(ImportCategoryProducts(dbContext, parth));

            //Export
            GetProductsInRange(dbContext);
            GetSoldProducts(dbContext);
        }

        //EXPORT
        public static string GetSoldProducts(ProductShopContext context)
        {

            var getSoldProductsu = context
                .Users
                .Where(x => x.ProductsSold.Count >= 1)
                .Select(y => new 
                {
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    SoldProducts = y.ProductsSold
                        .Select(ps => new
                        {
                            Name = ps.Name,
                            Price = ps.Price,
                            BuyerFirstName = ps.Buyer.FirstName,
                            BuyerLastName = ps.Buyer.LastName
                        })
                        .ToList()
                    })
                .OrderBy(x => x.LastName)
                .ThenBy(y => y.FirstName)
                .ToList();

            string jsonFile = JsonConvert.SerializeObject(getSoldProductsu, Formatting.Indented);
            File.WriteAllText("../../../Files/Export/users-sold-products.json", jsonFile);

            return "";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var getProducts = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(x => new
                {
                    Name = x.Name,
                    Price = x.Price,
                    Seller = (x.Seller.FirstName + " " + x.Seller.LastName).Trim()
                })
                .OrderBy(y => y.Price)
                .ToList();

            string jsonFile = JsonConvert.SerializeObject(getProducts, Formatting.Indented);
            File.WriteAllText("C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\/Files/Export/products-in-range.json", jsonFile);
            
            return "";
        }


        //IMPORT 
        public static string ImportUsers(ProductShopContext context, string inputJson)
        { 
            var jsonString = File.ReadAllText(inputJson);

            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonString);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {context.Users.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            //List<User> users = JsonSerializer.Deserialize<User>(jsonString);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {context.Products.Count()}";
        }


        // HELP
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(jsonString);

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {context.Categories.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<CategoryProduct> categoryProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(jsonString);

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();


            return $"Successfully imported {context.CategoryProducts.Count()}";
        }
    }
}