using System.Net.Mail;

namespace OpenClosed.After.Interface
{
    public interface IEmailService
    {
        bool ValidateEmail(string email);
        bool SendEmail(MailMessage message);
    }
}
