using SamplePos.Purchase;

namespace SamplePosTests.Fakes
{
    class PurchaseRepositoryFake : IPurchaseRepository
    {
        public bool AddWasCalled { get; private set; } = false;
        private object addWasCalledWithValue;

        public void Add(string param)
        {
            AddWasCalled = true;
            addWasCalledWithValue = param;
        }

        public bool AddWasCalledWith(string value)
        {
            return addWasCalledWithValue.Equals(value);
        }
    }
}
