using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPP
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal valueToPay()
        {
            return ((decimal)Quantity*Price)+ ((decimal)Quantity * Price)*(decimal)Tax;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeassurement: {Measurement}" +
                $"\n\tQuantity: {Quantity}" +
                $"\n\tPrice: {Price}" +
                $"\n\tTax: {Tax:P2}" +
                $"\n\tValue: {valueToPay()}";
        }
    }
}
