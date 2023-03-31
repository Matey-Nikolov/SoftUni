using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public double DefaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public virtual void Drive(double kilometers)
        {
            double fuelUsed = kilometers * DefaultFuelConsumption;
            Fuel -= fuelUsed;
        }
    }
}
