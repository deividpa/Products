using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private string _accumulator;

        public override decimal valueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            foreach (Product productItem in Products)
            {
                _accumulator += productItem.Description + ","; 
            }

            return $"{base.ToString()}" +
                $"\n\tDiscount...: {Discount}" +
                $"\n\tProducts...: {_accumulator}";
        }


        //public override string ToString()
        //{
        //    return $"{base.ToString()}" +
        //        $"\n\tMeassurement: {Measurement:N2}" +
        //        $"\n\tQuantity: {Quantity:N2}" +
        //        $"\n\tPrice: {Price:C2}" +
        //        $"\n\tTax: {Tax:P2}" +
        //        $"\n\tValue: {valueToPay()}";
        //}
    }
}
