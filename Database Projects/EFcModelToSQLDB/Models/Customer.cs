namespace EFcModelToSQLDB.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public required ICollection<Order> Orders { get; set; }
    }
}