using System;
using System.Runtime.InteropServices.WindowsRuntime;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Yellow mini sunflowers",
                CurrentPrice = 15.96M
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var UpdateProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Yellow mini sunflowers",
                CurrentPrice = 18M,
                HasChanges = true
            };

            var actual = productRepository.Save(UpdateProduct);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var UpdateProduct = new Product(2)
            {
                ProductName = null,
                ProductDescription = "Yellow mini sunflowers",
                CurrentPrice = 18M,
                HasChanges = true
            };

            var actual = productRepository.Save(UpdateProduct);

            Assert.AreEqual(false, actual);
        }
    }
}
