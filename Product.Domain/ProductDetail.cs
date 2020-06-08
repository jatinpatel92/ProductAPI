namespace Product.Domain
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ModelNumber { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; }
    }
}
