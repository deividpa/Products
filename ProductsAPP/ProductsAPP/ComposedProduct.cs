using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public class ComposedProduct : Product
    {
        public decimal Discount { get; set; }
        public int Products { get; set; }

        public override decimal valueToPay()
        {
            return 77;
        }
    }
}
