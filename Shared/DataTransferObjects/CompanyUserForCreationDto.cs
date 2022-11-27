using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record CompanyUserForCreationDto
    {
        [Required(ErrorMessage = "O campo Nome do usuário é obrigatório.")]
        [MaxLength(60, ErrorMessage = "O tamanho máximo para o nome do usuário é de 60 caracteres.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome do usuário é obrigatório.")]
        [MaxLength(60, ErrorMessage = "O tamanho máximo para o Sobrenome do usuário é de 60 caracteres.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "O campo Email do usuário é obrigatório.")]
        [MaxLength(180, ErrorMessage = "O tamanho máximo para o Email do usuário é de 180 caracteres.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Login do usuário é obrigatório.")]
        [MaxLength(60, ErrorMessage = "O tamanho máximo para o Login do usuário é de 60 caracteres.")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "O campo Senha do usuário é obrigatório.")]
        [MaxLength(60, ErrorMessage = "O tamanho máximo para o Senha do usuário é de 60 caracteres.")]
        public string? Password { get; set; }
    }
}
