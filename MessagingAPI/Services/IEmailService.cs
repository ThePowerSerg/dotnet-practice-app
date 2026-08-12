using MessagingAPI.Models;

namespace MessagingAPI.Services
{
    // Abstraction layer used for DI registration, tests, etc. 
    public interface IEmailService
    {
        void SendEmail(UserProfile user, string message);
    }
}