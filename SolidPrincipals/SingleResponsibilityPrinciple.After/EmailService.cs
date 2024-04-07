using OpenClosed.After.Interface;
using OpenClosed.Before.Interface;
using System.Net.Mail;

namespace OpenClosed.After
{
    public class EmailService: IEmailService
    {
        private readonly ISmtpClient _smtpClient;
        public EmailService(ISmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return email.Contains("@");
        }

        public bool SendEmail(MailMessage message)
        {
            return _smtpClient.SendEmail(message);
        }
    }
}
