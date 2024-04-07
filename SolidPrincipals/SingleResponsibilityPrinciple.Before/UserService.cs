using OpenClosed.Before.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace OpenClosed.Before
{
    public class UserService
    {
        private readonly ISmtpClient _smtpClient;
        private readonly IUserRepository _userRepository;

        public UserService(ISmtpClient smtpClient, IUserRepository userRepository)
        {
            _smtpClient = smtpClient;
            _userRepository = userRepository;
        }

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new ValidationException("Email is not a valid email");
            }

            var user = new User(email, password);
            _userRepository.Create(user);

            var mailMessage = new MailMessage("services@company.com", email) { Subject = "Welcome to Company" };
            SendEmail(mailMessage);
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

    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
