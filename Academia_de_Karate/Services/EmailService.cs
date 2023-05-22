using System.Net;
using System.Net.Mail;
using Academia_de_Karate.Options;

namespace Academia_de_Karate.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly EmailOptions emailOptions;

        public EmailService(IConfiguration configuration)
        {
            emailOptions = new EmailOptions();
            _configuration = configuration;
            _configuration.GetSection(nameof(EmailOptions)).Bind(emailOptions);
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = emailOptions.Email;

            var client = new SmtpClient(emailOptions.SmtpClient, emailOptions.Port)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mail, emailOptions.Password)
            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message)
            );
        }
    }
}