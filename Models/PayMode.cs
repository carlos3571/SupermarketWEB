namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Observation { get; set; }

        public ICollection<PayMode>? PayModes { get; set; }
    }
}
