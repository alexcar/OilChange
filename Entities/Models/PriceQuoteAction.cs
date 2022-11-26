namespace Entities.Models
{
    public class PriceQuoteAction : Entity
    {
        public string? Name { get; set; }
        public ICollection<PriceQuote>? PriceQuotes { get; set; } = new List<PriceQuote>();
    }
}
