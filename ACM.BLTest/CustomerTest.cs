﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Anisur",
                LastName = "Rahman"
            };
            string expected = "Anisur Rahman";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Rahman"
            };
            string expected = "Rahman";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Anisur"
            };
            string expected = "Anisur";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            Customer customer = new Customer();
            customer.FirstName = "Anisur";
            Customer.InstanceCount = 3;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
