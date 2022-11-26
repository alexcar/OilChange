namespace Entities.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool? Active { get; set; }        
        public DateTime? CreationDate { get; set; }
    }
}
