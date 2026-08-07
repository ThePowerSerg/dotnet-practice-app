using MessagingApp.Models;

namespace MessagingApp.Services
{
    public interface IEmailService
    {
        void SendEmail(UserProfile user, string message);
    }
}