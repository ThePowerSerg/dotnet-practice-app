namespace MessagingApp.Services
{
    public interface IMessageService
    {
        public string Message { get; set; }
        void SendMessage();
    }
}