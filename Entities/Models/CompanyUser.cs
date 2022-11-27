namespace Entities.Models
{
    public class CompanyUser : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }        
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public Guid PerfilId { get; set; }
        public Perfil? Perfil { get; set; }
        public ICollection<PriceQuote> PriceQuotes { get; set; }
    }
}
