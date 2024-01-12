namespace BratislavaApi.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryEntity Category { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }

        public decimal Total
        {
            get
            {
                var discount = Price * ((DiscountPercentage ?? 0) / 100);
                return Price - discount;
            }
        }
    }
}
