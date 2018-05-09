using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePos.Purchase
{
    class PurchaseRepository : IPurchaseRepository
    {
        public void Add(string param)
        {
            Console.WriteLine("hey");
        }
    }
}
