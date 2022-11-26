namespace Entities.Models
{
    public class PriceQuote : Entity
    {
        public int PriceQuoteNumber { get; set; }
        public string? Comments { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }        
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public Guid CompanyUserId { get; set; }
        public CompanyUser? CompanyUser { get; set; }
        public Guid PriceQuoteStatusId { get; set; }
        public PriceQuoteStatus? PriceQuoteStatus { get; set; }
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
        public Guid PriceQuoteActionId { get; set; }
        public PriceQuoteAction? PriceQuoteAction { get; set; }
        public Guid ReasonCancellationPriceQuoteId { get; set; }
        public ReasonCancellationPriceQuote? ReasonCancellationPriceQuote { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Service> Services { get; set; } = new List<Service>(); 
    }
}
