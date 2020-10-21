using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
        public void SaveTest()
        {
            var addressRepository = new AddressRepository();

            var update = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
                HasChanges = true
            };
            var actual = addressRepository.Save(update);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestPostalCodeMissing()
        {
            var addressRepository = new AddressRepository();

            var update = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = null,
                HasChanges = true
            };
            var actual = addressRepository.Save(update);

            Assert.AreEqual(false, actual);
        }
    }
}
