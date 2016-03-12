using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzAPIWeb;
using FizzBuzzAPIWeb.Controllers;

namespace FizzBuzzAPIWeb.Tests.Controllers
{
    [TestClass]
    public class FizzBuzzControllerTest
    {

        [TestMethod]
        public void Range1to3ResultShouldBeCorrect()
        {
            var controller = new FizzBuzzController();
            string expected = "1 2 fizz";
            string actual = controller.GetFizzBuzz(1, 3).result;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range4to6ResultShouldBeCorrect()
        {
            var controller = new FizzBuzzController();
            string expected = "4 buzz fizz";
            string actual = controller.GetFizzBuzz(4, 6).result;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range15to20ResultShouldBeCorrect()
        {
            var controller = new FizzBuzzController();
            string expected = "fizzbuzz 16 17 fizz 19 buzz";
            string actual = controller.GetFizzBuzz(15, 20).result;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range1to12ShouldReturnCorrectValueOfFizz()
        {
            var controller = new FizzBuzzController();
            int expected = 4;
            int actual = controller.GetFizzBuzz(1, 12).fizz;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range5to20ShouldReturnCorrectValueOfBuzz()
        {
            var controller = new FizzBuzzController();
            int expected = 3;
            int actual = controller.GetFizzBuzz(5, 20).buzz;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range10to45ShouldReturnCorrectValueOfFizzBuzz()
        {
            var controller = new FizzBuzzController();
            int expected = 3;
            int actual = controller.GetFizzBuzz(10, 45).fizzbuzz;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Range1to10ShouldReturnCorrectValueOfIntegers()
        {
            var controller = new FizzBuzzController();
            int expected = 5;
            int actual = controller.GetFizzBuzz(1, 10).integer;
            Assert.AreEqual(expected, actual);
        }
    }   
}
