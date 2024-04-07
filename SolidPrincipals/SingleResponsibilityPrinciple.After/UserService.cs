using OpenClosed.After.Interface;
using OpenClosed.After.Model;
using OpenClosed.Before.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace OpenClosed.Before
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public UserService(IUserRepository userRepository, IEmailService emailService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
            {
                throw new ValidationException("Email is not a valid email");
            }

            var user = new User() { Email = email, Password = password };
            _userRepository.Create(user);

            var mailMessage = new MailMessage("services@company.com", email) { Subject = "Welcome to Company" };
            _emailService.SendEmail(mailMessage);
        }
    }
}
