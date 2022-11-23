namespace EmailService
{
    public interface IEmailSender
    {
        Task SendEmail(string toName, string toAddress, string reason, string? subject, string? body);
    }
}
