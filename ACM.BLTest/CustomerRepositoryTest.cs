﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "anis@gmail.com",
                FirstName = "Anisur",
                LastName = "Rahman"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }

        [TestMethod]
        public void SaveTest()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "anis@gmail.com",
                FirstName = "Anisur",
                LastName = "Rahman",
                HasChanges = true
            };

            var actual = customerRepository.Save(expected);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingEmail()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = null,
                FirstName = "Anisur",
                LastName = "Rahman",
                HasChanges = true
            };

            var actual = customerRepository.Save(expected);

            Assert.AreEqual(false, actual);
        }
    }
}
 