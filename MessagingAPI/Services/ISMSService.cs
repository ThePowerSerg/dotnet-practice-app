using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    public interface ISMSService
    {
        void SendSMS(UserProfile user, string message);
    }
}