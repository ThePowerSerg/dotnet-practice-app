using MessagingApp.Models;

namespace MessagingApp.Services
{
    public class SMSService : IMessageService
    {
        public void SendMessage(UserProfile recipient, string message)
        {
            // Twilio send message to recipient.PhoneNumber
        }
    }
}