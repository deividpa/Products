
namespace ProductsAPP
{
    public class Invoice : IPay
    {
        private List<Product> _productItems;


        public Invoice()
        {
            _productItems = new List<Product>();
        }
        public Product AddProduct(Product product)
        {
            _productItems.Add(product);
            return product;
        }
        public decimal valueToPay()
        {
            decimal total = 0;
            foreach (Product product in _productItems)
            {
                total += product.valueToPay();
            }
            return total;
        }
        public override string ToString()
        {
            string productsInfo = "";
            foreach (Product product in _productItems)
            {
                productsInfo += product.ToString() + "\n";
            }
            return $"RECEIPT" +
                $"\n--------------------------------------------------" +
                $"\n{productsInfo}" +
                $"                        =============" +
                $"\nTOTAL: {$"                  {valueToPay():C2}",15}";
        }
    }
}
