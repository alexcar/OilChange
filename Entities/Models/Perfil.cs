namespace Entities.Models
{
    public class Perfil : Entity
    {
        public string? Name { get; set; }
        public ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public ICollection<Company> Companies { get; set; } = new List<Company>();
    }
}
