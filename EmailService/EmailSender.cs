using MailKit.Net.Smtp;
using MimeKit;

namespace EmailService
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public async Task SendEmail(string toName, string toAddress, string reason, string? subject, string? body)
        {
            if (reason == "registration")
            {
                subject = _emailConfig.RegistrationSubject; 
                body = _emailConfig.RegistrationBody;
            }
            
            var messageToSend = new MimeMessage()
            {
                Sender = new MailboxAddress(_emailConfig.Name, _emailConfig.Address),
                Subject = subject
            };

            messageToSend.Body = new TextPart(
                MimeKit.Text.TextFormat.Html)
            { Text = body };

            messageToSend.To.Add(new MailboxAddress(toName, toAddress));
            var response = "";
            
            using (var smtp = new SmtpClient())
            {
                smtp.MessageSent += (sender, args) => { response = args.Response; };
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;

                await smtp.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_emailConfig.From, _emailConfig.Password);
                await smtp.SendAsync(messageToSend);
                await smtp.DisconnectAsync(true);
            }
        }        

        //private async void Send2()
        //{
        //    var messageToSend = new MimeMessage()
        //    {
        //        Sender = new MailboxAddress("Oil Change", "oilchangesmart@outlook.com"),
        //        Subject = "Seja bem-vindo"
        //    };

        //    messageToSend.Body = new TextPart(
        //        MimeKit.Text.TextFormat.Plain) 
        //    { Text = "Seja bem-vindo a uma nova experiência para o serviço troca de óleo." };

        //    messageToSend.To.Add(new MailboxAddress("Alexandre Carvalho", "alexandre.carvalho@live.com"));
        //    var response = "";
        //    using (var smtp = new MailKit.Net.Smtp.SmtpClient())
        //    {
        //        smtp.MessageSent += (sender, args) => { response = args.Response; };
        //        smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;

        //        await smtp.ConnectAsync("smtp-mail.outlook.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
        //        await smtp.AuthenticateAsync("oilchangesmart@outlook.com", "qnewzgdppdwqqdyn");
        //        await smtp.SendAsync(messageToSend);
        //        await smtp.DisconnectAsync(true);
        //    }
        //}
    }
}
