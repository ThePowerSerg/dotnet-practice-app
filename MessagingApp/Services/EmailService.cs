namespace MessagingApp.Services
{
    public class EmailService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Email Service!";
        }
    }
}