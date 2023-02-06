using NUnit.Framework;
using P03_CarManager;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Constructors()
        {
            Car car = new Car("Me", "VF2", 21, 100);
            Car testCar = new Car("Me", "VF2", 21, 100);

            //CollectionAssert.AreEqual(testCar., car);
            Assert.AreEqual(car.Make, testCar.Make);
            Assert.AreEqual(car.Model, testCar.Model);
            Assert.AreEqual(car.FuelConsumption, testCar.FuelConsumption);
            Assert.AreEqual(car.FuelCapacity, testCar.FuelCapacity);
        
            //Car testCar = new Car("", "V2", 21, 100);
        }

        
        [Test]
        public void Test_AllProperties()
        {
            /*
            Car testFuelConsumptionCar = new Car("qw", "23", 0, 12);
            Assert.That(() => testFuelConsumptionCar.FuelConsumption, Throws.InstanceOf<ArgumentException>(), "Fuel consumption cannot be zero or negative!");

            Car testFuelCapacityCar = new Car("sd", "23", 12, 0);
           Assert.That(() => testFuelCapacityCar.FuelCapacity, Throws.InstanceOf<ArgumentException>(), "Fuel amount cannot be negative!");
            */

            Assert.Throws<ArgumentException>(() =>
            {
                Car testMakeProperty = new Car(null, "23", 12, 12);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                Car testModelProperty = new Car("A3", "", 12, 12);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                Car testFuelConsumptionProperty = new Car("A3", "2s", -1, 12);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                Car testFuelCapacityProperty = new Car("A3", "2s", 12, 0);
            });

            /*
            Assert.Throws<ArgumentException>(() =>
            {
                Car testFuelAmountProperty = new Car("A3", "2s", 2, 2);
                testFuelAmountProperty.Refuel(2);
            });
            */
        }

        [Test]
        public void Test_RefuelAll()
        {
            Car testRefuel = new Car("2", "W2", 10.1, 25.5);

            //Exception
            Assert.That(() => testRefuel.Refuel(0), Throws.InstanceOf<ArgumentException>(), "Fuel amount cannot be zero or negative!");
            Assert.That(() => testRefuel.Refuel(-5), Throws.InstanceOf<ArgumentException>(), "Fuel amount cannot be zero or negative!");

            //Work
            testRefuel.Refuel(5);
            Assert.That(testRefuel.FuelAmount, Is.EqualTo(5));

            testRefuel.Refuel(30);
            Assert.That(testRefuel.FuelCapacity, Is.EqualTo(25.5));
        }

        [Test]
        public void Test_Drive_Exception()
        {
            Car testDrive = new Car("2", "W2", 3.5, 15.5);

            //Exception
            Assert.That(() => testDrive.Drive(50), Throws.InstanceOf<InvalidOperationException>(), "You don't have enough fuel to drive!");
        }

        [Test]
        public void Test_Drive()
        {
            Car testDrive = new Car("2", "W2", 3, 15);

            //Work
            testDrive.Refuel(10);
            testDrive.Drive(5);
            // fuelNeeded = 0.15
            // 10 - 1.55 = 8.45
            Assert.That(testDrive.FuelAmount, Is.EqualTo(9.85));

            //testDrive.Refuel(30);
            //Assert.That(testDrive.FuelCapacity, Is.EqualTo(25.5));
        }
    }
}