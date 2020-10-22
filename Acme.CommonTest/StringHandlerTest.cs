using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            Assert.AreEqual("Anisur Rahman Sarker", StringHandler.InsertSpaces("AnisurRahmanSarker"));
        }

        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            Assert.AreEqual("Anisur Rahman Sarker", StringHandler.InsertSpaces("Anisur Rahman Sarker"));
        }
    } 
}
