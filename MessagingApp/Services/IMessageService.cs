using MessagingApp.Models;

namespace MessagingApp.Services
{
    public interface IMessageService
    {
        void SendMessage(UserProfile recipient, string message);
    }
}