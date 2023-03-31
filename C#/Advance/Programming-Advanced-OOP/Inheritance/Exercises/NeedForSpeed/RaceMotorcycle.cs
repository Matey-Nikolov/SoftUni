using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public double DefaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public virtual void Drive(double kilometers)
        {
            double fuelUsed = kilometers * DefaultFuelConsumption;
            Fuel -= fuelUsed;
        }
    }
}
