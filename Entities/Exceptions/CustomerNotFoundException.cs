namespace Entities.Exceptions
{
    public sealed class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(Guid customerId) 
            : base($"O cliente com o ID: {customerId} não existe.")
        {
        }
    }
}
