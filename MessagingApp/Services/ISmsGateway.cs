namespace MessagingApp.Services
{
    public interface ISmsGateway
    {
        void Send(string toPhoneNumber, string body);
    }
}
