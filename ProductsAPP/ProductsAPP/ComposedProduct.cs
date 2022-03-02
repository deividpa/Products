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

        public string Accumulator { get; set; }

        public decimal parcialValue { get; set; }
        public override decimal valueToPay()
        {
            foreach (Product nProduct in Products)
            {
                float totDiscount = 0;
                decimal indPrice;
                indPrice = nProduct.valueToPay();

                totDiscount = (float)indPrice*Discount;

                parcialValue += indPrice - (decimal)totDiscount;
            };
            return parcialValue;    
        }
        public override string ToString()
        {
            foreach (Product productItem in Products)
            {
                Accumulator += productItem.Description + ","; 
            }

            return $"{base.ToString()}" +
                $"\n\tProducts....: {$"{Accumulator}",15}" +
                $"\n\tDiscount....: {$"{Discount:P2}",15}" +
                $"\n\tValue.......: {$"{valueToPay():C2}",15}";
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
