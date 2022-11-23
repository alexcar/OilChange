namespace Shared.DataTransferObjects
{
    public record class AuthenticatedUserDto(
        Guid? Id,
        string FirstName,
        string LastName,
        string Email,
        string AccessToken, 
        string RefreshToken,
        bool IsAdmin
    );
    
}
