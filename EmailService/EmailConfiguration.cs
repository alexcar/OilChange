﻿namespace EmailService
{
    public class EmailConfiguration
    {
        public string From { get; set; }
        public string Password { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? RegistrationSubject { get; set; }
        public string? RegistrationBody { get; set; }
    }
}
