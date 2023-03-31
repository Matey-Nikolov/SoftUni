using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle 
    {
        public double DefaultFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public virtual void Drive(double kilometers)
        {
            double fuelUsed = kilometers * DefaultFuelConsumption;
            Fuel -= fuelUsed;
        }

    }
}
