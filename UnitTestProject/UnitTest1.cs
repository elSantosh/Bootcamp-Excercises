using System;
using UnitTestsExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest_Success()
        {
            // 3 A's

            // Arrange
            var first = 10;
            var second = 10;
            var expected = 20;
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(first, second);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddTest_ZeroPlusANumber()
        {
            // 3 A's

            // Arrange
            var first = 0;
            var second = 10;
            var expected = 10;
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(first, second);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest_Negative()
        {
            // 3 A's

            // Arrange
            var first = 10;
            var second = 5;
            var expected = 25;
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(first, second);

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            calculator.Subtract(9, 10);
        }
    }
    [TestClass()]
    public class StoreTests
    {

        [TestMethod()]
        public void FullOrderingProcessTest()
        {
            // Arrange
            var store = new Store();
            var productName = "XYZ";
            var customerName = "Mr. Jordan";
            var payment = 20.99;
            var address = "KL";

            var expectedProductName = "XYZ";
            var expectedCustomerName = "Mr. Jordan";
            var expectedPayment = (decimal)(20.99 * 0.06);
            var expectedAddress = "KL";


            // Act
            var order = store.OrderAProduct(productName, customerName);
            order = store.PayForProduct(order, (decimal)payment);
            order = store.DeliverOrder(order, address);


            // Assert
            

            Assert.IsNotNull(order.OrderNumber, "Order number is null.");
            Assert.AreNotEqual(order.OrderNumber, string.Empty);
            Assert.AreEqual(expectedProductName, order.ProductName);
            Assert.AreEqual(expectedCustomerName, order.CustomerName);
            Assert.AreEqual(expectedPayment, order.Payment);
            Assert.AreEqual(expectedAddress, order.Address);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Customer name cannot be empty.")]
        public void FullOrderingProcessTest_MustThrowCustomerNameException()
        {
            // Arrange
            var store = new Store();
            var productName = "XYZ";
            var customerName = "";


            // Act
            var order = store.OrderAProduct(productName, customerName);


            // Assert
        }
    }
}
