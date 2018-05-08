using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamplePos.Purchase
{
    interface IPurchaseRepository
    {
        void Add(string itemId);
    }
}
