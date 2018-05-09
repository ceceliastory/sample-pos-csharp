using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamplePos.Purchase;
using SamplePosTests.Fakes;

namespace SamplePosTests
{
    [TestClass]
    public class PurchaseServiceTest
    {
        private readonly PurchaseRepositoryFake purchaseRepositoryFake = new PurchaseRepositoryFake();
        private PurchaseService purchaseService;

        [TestInitialize]
        public void SetUp()
        {
            purchaseService = new PurchaseService(purchaseRepositoryFake);
        }

        [TestMethod]
        public void ShouldRecieveItemIdAndSave()
        {
            purchaseService.Add("12345");

            Assert.IsTrue(purchaseRepositoryFake.AddWasCalled);
            Assert.IsTrue(purchaseRepositoryFake.AddWasCalledWith("12345"));
        }
    }
}
