namespace Entities.Models
{
    public class Customer : Entity
    {
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string? Address { get; set; }
        public string? Complement { get; set; }
        public string? Neighborhood { get; set; }
        public string? County { get; set; }        
        public string? Uf { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public Guid? PerfilId { get; set; }
        public Perfil? Perfil { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<PriceQuote>? PriceQuotes { get; set; } = new List<PriceQuote>(); 
    }
}
