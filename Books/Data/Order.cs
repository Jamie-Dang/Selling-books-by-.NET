using System.ComponentModel.DataAnnotations;

namespace Books.Data
{
    public class Order
    {
        public int? Id { get; set; }
        [StringLength(450)]// chiều dài bằng userid trong bảng user dùng cho identity
        public string UserId { get; set; } = null!;
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
       
        public double? Total { get; set; }
        public string? Address { get; set; }
        public int? Phone { get; set; }
        public string? Payment { get; set; }
        public int? CustomerID { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
