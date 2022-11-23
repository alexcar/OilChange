namespace Entities.Exceptions
{
    public sealed class CpfAlreadyRegisteredException : BadRequestException
    {
        public CpfAlreadyRegisteredException(string cpf) 
            : base($"Já existe um cliente cadastrado com o CPF: {cpf}.")
        {
        }
    }
}
