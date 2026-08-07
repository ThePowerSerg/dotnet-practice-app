using MessagingApp.Models;

namespace MessagingApp.Services
{
    public class EmailService : IMessageService
    {
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendMessage(UserProfile recipient, string message)
        {
            var toAddress = recipient.Email
                ?? throw new InvalidOperationException($"User '{recipient.UserName}' has no email address.");

            _emailSender.Send(toAddress, message);
        }
    }
}