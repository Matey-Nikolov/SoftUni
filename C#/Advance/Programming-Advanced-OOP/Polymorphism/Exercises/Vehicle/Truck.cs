using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public double AdditionalConsumptionPerKm = 1.6;

        private double refuelingCoefficient = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double AdditionalConsumption => AdditionalConsumptionPerKm;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * refuelingCoefficient);
        }
    }
}