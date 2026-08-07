using MessagingApp.Models;
using MessagingApp.Services;

namespace MessagingApp.Controllers
{
    // consuming class - defines the implementation
    public class MessageController
    {
        private readonly IEmailService emailService;
        private readonly ISMSService sMSService;

        public MessageController(IEmailService emailService, ISMSService sMSService)
        {
            this.emailService = emailService;
            this.sMSService = sMSService;
        }

        public void SendEmail(UserProfile user, string message)
        {
            emailService.SendEmail(user, message);
        }
        public void SendSMS(UserProfile user, string message)
        {
            sMSService.SendSMS(user, message);
        }
    }
}