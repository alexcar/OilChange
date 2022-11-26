namespace Entities.Models
{
    public class ReasonCancellationPriceQuote : Entity
    {
        public string? Name { get; set; }
        public ICollection<PriceQuote>? PriceQuotes { get; set; } = new List<PriceQuote>();
    }
}
