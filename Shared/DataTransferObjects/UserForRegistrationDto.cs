using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record UserForRegistrationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Nome do usuário é obrigatório")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Informe uma senha")]
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<string>? Roles { get; set; }
    }
}
