namespace Entities.Models
{
    public class PaymentMethod : Entity
    {
        public string? Name { get; set; }
        public decimal? ValueDiscount { get; set; }
        public int? PercentageDiscount { get; set; }
        public ICollection<PriceQuote>? PriceQuotes { get; set; } = new List<PriceQuote>();
    }
}
