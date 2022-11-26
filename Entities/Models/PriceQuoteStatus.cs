namespace Entities.Models
{
    public class PriceQuoteStatus : Entity
    {
        public string? Name { get; set; }
        public ICollection<PriceQuote> PriceQuotes { get; set; } = new List<PriceQuote>();
    }
}
