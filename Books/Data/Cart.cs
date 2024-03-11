namespace Books.Data
{
	public class Cart
	{
		public int Id { get; set; }
		public int? CustomerID { get; set; }
		public Customer? Customer { get; set; }
		public double? Total { get; set; }

		public ICollection<CartDetail>? CartDetails { get; set; }
	}
}
