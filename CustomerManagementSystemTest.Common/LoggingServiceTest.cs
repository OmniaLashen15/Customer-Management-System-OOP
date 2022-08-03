using CustomerManagementSystem;
using CustomerManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CustomerManagementSystemTest.Common
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "fbaggins@hobbiton.com",
                AddressList = null
            };
            changedItems.Add(customer);
            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel head",
                CurrentPrice = 6m
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
        }
    }
}
