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
            return Price*(decimal)Tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tPrice: {Price:C2}" +
                $"\n\tTax: {Tax:P2}" +
                $"\n\tValue: {valueToPay():C2}";
        }
    }
}
