using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public class VehicleForCreationDto
    {
        [Required(ErrorMessage = "O campo Placa é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O tamanho máximo para o campo Placa é de 15 caracteres.")]
        public string? LicencePlate { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório.")]
        public Guid ModelId { get; set; }
        
        [Required(ErrorMessage = "O campo Marca é obrigatório.")]
        public Guid BrandId { get; set; }
        
        [Required(ErrorMessage = "O campo Combustível é obrigatório.")]
        public Guid FuelId { get; set; }

        [Required(ErrorMessage = "O campo Ano é obrigatório.")]
        public Guid YearId { get; set; }
        public bool Active { get; set; }
    }
}
