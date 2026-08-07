namespace MessagingApp.Services
{
    public interface IEmailSender
    {
        void Send(string toAddress, string body);
    }
}
