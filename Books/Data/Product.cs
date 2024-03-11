namespace Books.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public double? Price { get; set; }
        public double? ProPrice { get; set; }
        public string? ImageURL { get; set; }

        public string? Author { get; set; }
        public Category? Category { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
		public ICollection<CartDetail>? CartDetails { get; set; }
	}
}
