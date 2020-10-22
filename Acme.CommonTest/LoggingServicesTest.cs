using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServicesTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItem = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "anis@g.com",
                FirstName = "Anis",
                LastName = "Sarker",
                AddressList = null
            };
            changedItem.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel head",
                CurrentPrice = 21M
            };
            changedItem.Add(product);

            LoggingServices.WriteToFile(changedItem);
        }
    }
}
