using System.ComponentModel.DataAnnotations;

namespace EFcModelToSQLDB.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        public required Customer Customer { get; set; }

        public required ICollection<ProductOrder> ProductOrders { get; set; }
    }
}