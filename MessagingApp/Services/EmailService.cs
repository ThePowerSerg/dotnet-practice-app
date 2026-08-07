namespace MessagingApp.Services
{
    public class EmailService : IMessageService
    {
        public required string Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine(Message);
        }
    }
}