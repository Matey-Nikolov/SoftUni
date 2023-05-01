using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double ConsumptionLitersPerKm { get; set; }
        //public double TankCapacity { get; set; }

        public abstract double AdditionalConsumption { get; }

        public Vehicle(double fuelQuantity, double consumption)
        { 
            FuelQuantity = fuelQuantity;
            ConsumptionLitersPerKm = consumption;

            //TankCapacity = tankCapacity;
        }

        public string Drive(double distance)
        {
            double requiredFuel = (ConsumptionLitersPerKm + AdditionalConsumption) * distance;

            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}