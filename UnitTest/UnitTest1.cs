using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Abstraction_and_polimo;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Syntaksis_error_village()
        {
            Assert.ThrowsException<FormatException>(() => new Village(Convert.ToInt32("dsf"), 15, 4));
        }
        [TestMethod]
        public void Number_error_village() {
            var test = new Village(20, 15, 0);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => test.Density());
        }
        [TestMethod]
        public void Complete_test_village() {
            var test = new Village(25, 8, 1.3);
            double res = 153.85;
            Assert.AreEqual(res, Math.Round(test.Density(),2));
        }
        [TestMethod]
        public void Syntaksis_error_city()
        {
            Assert.ThrowsException<FormatException>(() => new City(1, Convert.ToInt32("dsf")));
        }
        [TestMethod]
        public void Number_error_city()
        {
            var test = new City(20, 0);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => test.Density());
        }
        [TestMethod]
        public void Complete_test_city()
        {
            var test = new City(100000, 20.2);
            double res = 4950.5;
            Assert.AreEqual(res, Math.Round(test.Density(), 2));
        }
    }
}
