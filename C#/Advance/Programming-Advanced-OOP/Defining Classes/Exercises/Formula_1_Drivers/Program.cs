namespace Formula_1_Drivers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            List<Driver> drivers = new List<Driver>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0] + " " + input[1];
                int age = int.Parse(input[2]);
                float totalName = float.Parse(input[3]);
                float speed = float.Parse(input[4]);

                Driver driver = new Driver(name, age, totalName, speed);

                drivers.Add(driver);
            }

            float speed2 = 0;

            foreach (var item in drivers)
            {
                if (item.Speed > speed2)
                {
                    speed2 = item.Speed;
                }
            }

            var findDriver = drivers.Find(x => x.Speed == speed2);

            Console.WriteLine($"DriverName: {findDriver.Name}");
            Console.WriteLine($"  DriverAge: {findDriver.Age}");
            Console.WriteLine($"    Time: {findDriver.TotalTime}");
            Console.WriteLine($"    Speed: {findDriver.Speed}");

        }
    }
}