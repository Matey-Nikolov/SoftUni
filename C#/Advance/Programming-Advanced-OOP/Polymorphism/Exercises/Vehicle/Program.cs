using System;

namespace Vehicles
{
    public class Program
    {
        static void Main()
        {
            string[] inputCarTruckOrBus = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantity = double.Parse(inputCarTruckOrBus[1]);
            double consumptionLitersPerKm = double.Parse(inputCarTruckOrBus[2]);

            Vehicle car = new Car(fuelQuantity, consumptionLitersPerKm);

            inputCarTruckOrBus = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            fuelQuantity = double.Parse(inputCarTruckOrBus[1]);
            consumptionLitersPerKm = double.Parse(inputCarTruckOrBus[2]);

            Vehicle truck = new Truck(fuelQuantity, consumptionLitersPerKm);




            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string driveOrRefuel = input[0];
                string carOrTruck = input[1];
                double litersOrDistance = double.Parse(input[2]);

                switch (driveOrRefuel)
                {
                    case "Drive":
                        switch (carOrTruck)
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(litersOrDistance));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(litersOrDistance));
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (carOrTruck)
                        {
                            case "Car":
                                car.Refuel(litersOrDistance);
                                break;
                            case "Truck":
                                truck.Refuel(litersOrDistance);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}