using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }

        public abstract decimal valueToPay();
        public override string ToString()
        {
            return $"{Description}";
        }

    }
}
