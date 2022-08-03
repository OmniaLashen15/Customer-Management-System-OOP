using CustomerManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Customer_Management_System_Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                CurrentPrice = 15.96m
            };
            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18m,
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "Sunflowers",
                HasChanged = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);

        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "Sunflowers",
                HasChanged = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);

        }
    }
}
