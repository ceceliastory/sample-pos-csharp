using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamplePos.Purchase
{
    public class PurchaseService
    {
        private readonly IPurchaseRepository purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            this.purchaseRepository = purchaseRepository;
        }

        public void Add(string itemId)
        {
            purchaseRepository.Add(itemId);
        }
    }
}
