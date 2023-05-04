﻿using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTestsClass
    {
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestAccurateGasTank()
        {
            test_car.Drive(50);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestAccurateGasTank1()
        {
            test_car.Drive(60);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}
