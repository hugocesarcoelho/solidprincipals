using System.Net.Mail;

namespace OpenClosed.Before.Interface
{
    public interface ISmtpClient
    {
        bool SendEmail(MailMessage mailMessage);
    }
}
