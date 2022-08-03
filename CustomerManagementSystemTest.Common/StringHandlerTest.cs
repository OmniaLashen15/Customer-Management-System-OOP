using CustomerManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerManagementSystemTest.Common
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //Act
            ///var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //Act
            ///var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
