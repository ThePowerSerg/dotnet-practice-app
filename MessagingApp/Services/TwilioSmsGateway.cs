namespace MessagingApp.Services
{
    // Stands in for a real Twilio client. This is the one class allowed to
    // know how SMS actually gets sent.
    public class TwilioSmsGateway : ISmsGateway
    {
        public void Send(string toPhoneNumber, string body)
        {
            // Twilio send message
        }
    }
}
