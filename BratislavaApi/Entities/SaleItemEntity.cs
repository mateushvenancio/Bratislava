namespace BratislavaApi.Entities
{
    public class SaleItemEntity
    {
        public ProductEntity Product { get; set; }
        public decimal Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Total * Quantity;
            }
        }
    }
}
