using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public class VariablePriceProduct : Product
    {
        public float Meassurement { get; set; }
        public int Quantity { get; set; }

        public override decimal valueToPay()
        {
            return 52;
        }
    }
}
