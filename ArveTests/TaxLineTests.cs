using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bill.Models;

namespace ArveTests
{
    [TestClass]
    public class TaxLineTests
    {
        [TestMethod]
        public void TaxTest()
        {
            TaxLine.Tax = 0.5;
            Assert.AreEqual(0.5, TaxLine.Tax);
        }
        [TestMethod]
        public void TaxResultTest()
        {
            TaxLine.TaxResult = 0.4;
            Assert.AreEqual(0.4, TaxLine.TaxResult);

        }
        [TestMethod]
        public void TaxCalculateTest()
        {
            // 

        }
    }
}
