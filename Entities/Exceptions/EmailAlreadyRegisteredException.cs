namespace Entities.Exceptions
{
    public sealed class EmailAlreadyRegisteredException : BadRequestException
    {
        public EmailAlreadyRegisteredException(string email)
            : base($"Já existe um cliente cadastrado com o email: {email}.")
        {
        }
    }
}
