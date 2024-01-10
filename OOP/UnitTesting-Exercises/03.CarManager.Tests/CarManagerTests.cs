namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new Car("Mercedes", "S63", 7.5, 50.0);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual("Mercedes", car.Make);
            Assert.AreEqual("S63", car.Model);
            Assert.AreEqual(7.5, car.FuelConsumption);
            Assert.AreEqual(50.0, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [TestCase("")]
        [TestCase(null)]
        public void MakePropertyShouldThrowAnExceptionWhenNullOrEmpty(string make)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car(make, "S63", 7.5, 50.0));

            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }

        [TestCase("")]
        [TestCase(null)]
        public void ModelPropertyShouldThrowAnExceptionWhenNullOrEmpty(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Mercedes", model, 7.5, 50.0));

            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FuelConsumptionPropertyShouldThrowAnExceptionWhen0OrLess(int fuelConsumption)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Mercedes", "S63", fuelConsumption, 50.0));

            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }

        [Test]
        public void FuelAmountShouldThrowExceptionIfIsNegative()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(12), "Fuel amount cannot be negative!");
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FuelCapacityPropertyShouldThrowAnExceptionWhen0OrLess(int fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Mercedes", "S63", 7.5, fuelCapacity));

            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }

        [Test]
        public void RefuelMethodShouldWorkCorrectly()
        {
            car.Refuel(15);

            double expectedResult = 15;

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelMethodThrowAnExceptionIfZeroOrLess(int amount)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => car.Refuel(amount));

            Assert.AreEqual("Fuel amount cannot be zero or negative!", exception.Message);
        }

        [Test]
        public void RefuelMethodShouldSetAmountToTheCapacityIfOverfueled()
        {
            car.Refuel(100);

            double expectedResult = car.FuelCapacity;

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        [Test]
        public void DriveMethodShouldWorkCorrectly()
        {
            car.Refuel(10);
            car.Drive(100);

            double expectedResult = 2.5;

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        [Test]
        public void DriveMethodShouldThrowAnExceptionWhenFuelAmountIsLessThanFuelNeed()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => car.Drive(100));

            Assert.AreEqual("You don't have enough fuel to drive!", exception.Message);
        }
    }
}