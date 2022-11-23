namespace Shared.DataTransferObjects
{
    public record CompanyDto(
        Guid Id, string Name, string CommercialName, string Cnpj,
        string contact, string Ddd, string Phone,
        string Website, string Email, string Address,
        string Neighborhood, string County, string Country,
        string Uf, string Zipcode, Boolean Active, Guid UserUpdate);
}
