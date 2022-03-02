using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public class FixedPriceProduct : Product
    {
        public override decimal valueToPay()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"Price value: {valueToPay}";
        }
    }
}
