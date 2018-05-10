using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamplePos;
using SamplePos.Purchase;

namespace SamplePosTests
{
    [TestClass]
    public class PosViewModelTest
    {
        FakePurchaseService fakePurchaseService;
        PosViewModel posViewModel;

        [TestInitialize]
        public void SetUp()
        {
            fakePurchaseService = new FakePurchaseService();
            posViewModel = new PosViewModel(fakePurchaseService);
        }

        [TestMethod]
        public void ShouldSaveItemInServiceWhenItemIdIsSet()
        {
            posViewModel.ItemId = "some id";

            posViewModel.SaveItem.Execute("");

            Assert.IsTrue(fakePurchaseService.AddWasCalledWith("some id"));
        }   
        
        [TestMethod]
        public void ShouldNotSaveItemInServiceWhenItemIdIsNotSet()
        {
            posViewModel.SaveItem.Execute("");

            Assert.IsFalse(fakePurchaseService.AddWasCalled());
        }
    }

    public class FakePurchaseService : IPurchaseService
    {
        private string itemIdAdded;
        private bool addWasCalled = false;
        
        public void Add(string itemId)
        {
            itemIdAdded = itemId;
            addWasCalled = true;
        }

        public bool AddWasCalledWith(object param)
        {
            return itemIdAdded != null && itemIdAdded.Equals(param);
        }

        public bool AddWasCalled()
        {
            return addWasCalled;
        }
    }
}
