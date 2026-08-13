using MessagingAPI.Models;
using MessagingAPI.Services;

namespace MessagingAPI.Controllers
{
    // TODO: Move to front-end
    
    // consuming class - coordinates which services will be consumed by the UI and communicates with the UI. 
    public class MessageController(IEmailService emailService, ISMSService sMSService)
    {
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