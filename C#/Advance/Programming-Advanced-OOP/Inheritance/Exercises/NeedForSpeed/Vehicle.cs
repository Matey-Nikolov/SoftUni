using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption = 1.25;
        public double Fuel;
        public int HorsePower;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            double fuelUsed = kilometers * DefaultFuelConsumption;
            Fuel -= fuelUsed;
        }
    }
}
