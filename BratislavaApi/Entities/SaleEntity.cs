namespace BratislavaApi.Entities
{
    public class SaleEntity
    {
        public int Id { get; set; }
        public List<SaleItemEntity> ProductItems { get; set; }
        public DateTime CreatedAt { get; set; }

        public decimal Total
        {
            get
            {
                return ProductItems.Aggregate(0m, (total, atual) => total + atual.Total);
            }
        }
    }
}
