using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company : Entity
    {
        public string? Name { get; set; }
        public string? CommercialName { get; set; }
        public string? Cnpj { get; set; }
        public string? Contact { get; set; }
        public string? Ddd { get; set; }
        public string? Phone { get; set; }
        public string? WebSite { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Neighborhood { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? UF { get; set; }
        public string? ZipCode { get; set; }

        public ICollection<Infrastructure>? Infrastructures { get; set; } = new List<Infrastructure>();
        public ICollection<Service>? Services { get; set; } = new List<Service>();
    }
}
