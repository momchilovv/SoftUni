namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [Test]
        public void ConstructorShouldInitializeCarMake()
        {
            // Arrange & Act
            string expectedMake = "BMW";

            Car car = new Car(expectedMake, "525i", 9.9, 70.0);

            string actualMake = car.Make;

            // Assert
            Assert.AreEqual(expectedMake, actualMake);
        }

        [Test]
        public void ConstructorShouldInitializeCarModel()
        {
            // Arrange & Act
            string expectedModel = "525i";

            Car car = new Car("BMW", expectedModel, 9.9, 70.0);

            string actualModel = car.Model;

            // Assert
            Assert.AreEqual(expectedModel, actualModel);
        }

        [Test]
        public void ConstructorShouldInitializeCarFuelConsumption()
        {
            // Arrange & Act
            double expectedConsumption = 9.9;

            Car car = new Car("BMW", "525i", expectedConsumption, 70.0);

            double actualConsumption = car.FuelConsumption;

            // Assert
            Assert.AreEqual(expectedConsumption, actualConsumption);
        }

        [Test]
        public void ConstructorShouldInitializeCarFuelCapacity()
        {
            // Arrange & Act
            double expectedCapacity = 70.0;

            Car car = new Car("BMW", "525i", 9.9, expectedCapacity);

            double actualCapacity = car.FuelCapacity;

            // Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestCase("BMW")]
        [TestCase("Mercedes")]
        [TestCase("Lamborghini")]
        public void MakeSetterShouldSetValidMake(string make)
        {
            // Arrange & Act
            Car car = new Car(make, "pe4ka", 9.9, 70);

            string expectedMake = make;
            string actualMake = car.Make;

            // Assert
            Assert.AreEqual(expectedMake, actualMake);
        }

        [TestCase(null)]
        [TestCase("")]
        public void MakeSetterShouldThrowNullOrEmptyException(string make)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, "pe4ka", 9.9, 70.0);
            }, "Make cannot be null or empty!");
        }

        [TestCase("525i")]
        [TestCase("X5")]
        [TestCase("M4")]
        public void ModelSetterShouldSetValidModel(string model)
        {
            // Arrange & Act
            Car car = new Car("BMW", model, 9.9, 70);

            string expectedModel = model;
            string actualModel = car.Model;

            // Assert
            Assert.AreEqual(expectedModel, actualModel);
        }

        [TestCase(null)]
        [TestCase("")]
        public void ModelSetterShouldThrowNullOrEmptyException(string model)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", model, 9.9, 70.0);
            }, "Model cannot be null or empty!");
        }

        [TestCase(1)]
        [TestCase(5.5)]
        [TestCase(10)]
        public void FuelConsumptionSetterShouldSetValidConsumption(double consumption)
        {
            // Arrange & Act
            Car car = new Car("BMW", "525i", consumption, 70.0);

            double expectedConsumption = consumption;
            double actualConsumption = car.FuelConsumption;

            // Assert
            Assert.AreEqual(expectedConsumption, actualConsumption);
        }

        [TestCase(-5)]
        [TestCase(0)]
        public void FuelConsumptionSetterCanNotBeNegativeOrZero(double consumption)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "525i", consumption, 70.0);
            }, "Fuel consumption cannot be zero or negative!");
        }

        [TestCase(50.0)]
        [TestCase(65.5)]
        [TestCase(70)]
        public void FuelCapacitySetterShouldSetValidCapacity(double capacity)
        {
            // Arrange & Act
            Car car = new Car("BMW", "525i", 9.9, capacity);

            double expectedCapacity = capacity;
            double actualCapacity = car.FuelCapacity;

            // Assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void FuelCapacitySetterCanNotBeNegativeOrZero(double capacity)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "525i", 9.9, capacity);
            }, "Fuel capacity cannot be zero or negative!");
        }

        [TestCase(-10.0)]
        [TestCase(-1.0)]
        [TestCase(0)]
        public void RefuelAmountCanNotBeNegativeOrZero(double amount)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "525i", 9.9, 70.0);
                car.Refuel(amount);
            }, "Fuel amount cannot be zero or negative!");
        }

        [TestCase(20)]
        [TestCase(5.5)]
        [TestCase(2)]
        public void RefuelAmountIsAddedToFuelCapacity(double amount)
        {
            // Arrange
            Car car = new Car("BMW", "525i", 9.9, 70);
            double expectedAmount = amount;

            // Act
            car.Refuel(amount);

            // Assert
            Assert.AreEqual(expectedAmount, car.FuelAmount);
        }

        [TestCase(80.5)]
        [TestCase(70.5)]
        public void RefuelingMoreThanFuelCapacityIsMaxingTheFuelAmount(double amount)
        {
            // Arrange
            Car car = new Car("BMW", "525i", 9.9, 70);

            // Act
            car.Refuel(amount);

            // Assert
            Assert.AreEqual(car.FuelAmount, 70);
        }

        [TestCase(1000.20)]
        [TestCase(24942.18)]
        public void DrivingWithoutEnoughFuelShouldThrowException(double distance)
        {
            // Arrange
            Car car = new Car("BMW", "525i", 9.9, 70);
            car.Refuel(5);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(distance);
            }, "You don't have enough fuel to drive!");
        }

        [Test]
        public void DrivingWithEnoughFuelShouldDecreaseTheFuelAmount()
        {
            // Arrange
            Car car = new Car("BMW", "525i", 9.9, 70);
            car.Refuel(70);
            double fuelNeeded = (200 / 100) * car.FuelConsumption;

            double expectedAmount = 70 - fuelNeeded; 

            // Act
            car.Drive(200);

            // Assert
            Assert.AreEqual(expectedAmount, car.FuelAmount);
        }
    }
}