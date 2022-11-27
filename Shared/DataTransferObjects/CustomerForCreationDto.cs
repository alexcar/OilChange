using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record CustomerForCreationDto()
    {
        // HOTO: Incluir o campo password
        
        [Required(ErrorMessage = "O campo Nome do cliente é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O tamanho máximo para o nome do cliente é de 100 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo para o Cpf é de 14 caracteres.")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O campo Sexo é obrigatório.")]
        public string? sex { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string? Address { get; set; }
        public string? Complement { get; set; }

        [Required(ErrorMessage = "O campo bairro é obrigatório.")]
        public string? Neighborhood { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string? County { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        public string? Uf { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        public string? Zipcode { get; set; }
        public string? Country { get; set; }
        public Boolean Active { get; set; }
        public Guid UserUpdate { get; set; }
    }
        
}
