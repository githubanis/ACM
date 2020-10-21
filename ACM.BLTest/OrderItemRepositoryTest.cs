using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderItemRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var orderItemRepository = new OrderItemRepository();

            var expected = new OrderItem(1)
            {
                Quantity = 20
            };
            var actual = orderItemRepository.Retrieve(1);

            Assert.AreEqual(expected.Quantity, actual.Quantity);
        }

        [TestMethod]
        public void SaveTest()
        {
            var orderItemRepository = new OrderItemRepository();

            var expected = new OrderItem(1)
            {
                Quantity = 20
            };
            var actual = orderItemRepository.Save(expected);

            Assert.AreEqual(true, actual);
        }
    }
}
