using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamplePos.Purchase;

namespace SamplePosTests
{
    [TestClass]
    public class PurchaseServiceTest
    {

        private readonly PurchaseService purchaseService = new PurchaseService();

        [TestMethod]
        public void ShouldRecieveItemIdAndSave()
        {

            purchaseService.Add("12345");

        }
    }
}
