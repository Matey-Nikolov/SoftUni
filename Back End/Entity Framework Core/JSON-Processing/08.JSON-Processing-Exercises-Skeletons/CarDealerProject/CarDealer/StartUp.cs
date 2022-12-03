namespace CarDealer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using AutoMapper;
    using CarDealer.Data;
    using CarDealer.Models;
    using Newtonsoft.Json;
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext dbContex = new CarDealerContext();
            string path = "";

            path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\CarDealerProject\\CarDealer\\Datasets\\suppliers.json";
            ImportSuppliers(dbContex, path);

            path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\CarDealerProject\\CarDealer\\Datasets\\parts.json";
            ImportParts(dbContex, path);

            path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\CarDealerProject\\CarDealer\\Datasets\\cars.json";
            ImportCars(dbContex, path);

            path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\CarDealerProject\\CarDealer\\Datasets\\customers.json";
            ImportCustomers(dbContex, path);

            path = "C:\\Users\\matey\\Downloads\\08.JSON-Processing-Exercises-Skeletons\\CarDealerProject\\CarDealer\\Datasets\\sales.json";
            ImportSales(dbContex, path);
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Sale> sales = JsonConvert.DeserializeObject<List<Sale>>(jsonString);

            context.Sales.AddRange(sales);
            context.SaveChanges();


            return $"Successfully imported {context.Sales.Count()}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(jsonString);

            context.Customers.AddRange(customers);
            context.SaveChanges();


            return $"Successfully imported {context.Customers.Count()}";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(jsonString);

            context.Cars.AddRange(cars);
            context.SaveChanges();


            return $"Successfully imported {context.Cars.Count()}";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Part> parts = JsonConvert.DeserializeObject<List<Part>>(jsonString);

            context.Parts.AddRange(parts);
            context.SaveChanges();


            return $"Successfully imported {context.Parts.Count()}";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var jsonString = File.ReadAllText(inputJson);

            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(jsonString);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();


            return $"Successfully imported {context.Suppliers.Count()}";
        }
    }
}