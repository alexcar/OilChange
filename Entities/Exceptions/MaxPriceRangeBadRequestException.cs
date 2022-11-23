namespace Entities.Exceptions
{
    public sealed class MaxPriceRangeBadRequestException : BadRequestException
    {
        public MaxPriceRangeBadRequestException()
            : base("Preço máximo não pode ser menor que o preço mínimo.")
        {
        }
    }
}
