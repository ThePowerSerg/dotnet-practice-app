using MessagingApp.Models;

namespace MessagingApp.Services
{
    public class EmailService : IMessageService
    {
        public void SendMessage(UserProfile recipient, string message)
        {
            Console.WriteLine($"Emailing {recipient.Email}: {message}");
        }
    }
}