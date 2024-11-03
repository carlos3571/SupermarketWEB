namespace SupermarketWEB.Models
{
    public class Providers
    {
        public int Id { get; set; } 
        public int Document { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Addres { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }

        public ICollection<Providers>? providers { get; set; }

    }
}
