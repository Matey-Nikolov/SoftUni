using System;
using System.ComponentModel.DataAnnotations;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            int horsePower = int.Parse(Console.ReadLine());
            double fuel =  double.Parse(Console.ReadLine());
            int drivenKilometers = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "FamilyCar":
                    FamilyCar familyCar = new FamilyCar(horsePower, fuel);
                    familyCar.Drive(drivenKilometers);
                    Console.WriteLine($"Left fuel: {familyCar.Fuel:f2}");
                break;
                case "SportCar":
                    SportCar sportCar = new SportCar(horsePower, fuel);
                    sportCar.Drive(drivenKilometers);
                    Console.WriteLine($"Left fuel: {sportCar.Fuel:f2}");
                break;
                case "RaceMotorcycle":
                    RaceMotorcycle raceMotorcycle = new RaceMotorcycle(horsePower, fuel);
                    raceMotorcycle.Drive(drivenKilometers);
                    Console.WriteLine($"Left fuel: {raceMotorcycle.Fuel:f2}");
                break;
                case "Motorcycle":
                    Motorcycle motorcycle = new Motorcycle(horsePower, fuel);
                    motorcycle.Drive(drivenKilometers);
                    Console.WriteLine($"Left fuel: {motorcycle.Fuel:f2}");
                break;
            }
        }
    }
}
