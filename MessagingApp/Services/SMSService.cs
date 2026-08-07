using MessagingApp.Models;

namespace MessagingApp.Services
{
    public class SMSService : IMessageService
    {
        private readonly ISmsGateway _smsGateway;

        public SMSService(ISmsGateway smsGateway)
        {
            _smsGateway = smsGateway;
        }

        public void SendMessage(UserProfile recipient, string message)
        {
            var toPhoneNumber = recipient.PhoneNumber
                ?? throw new InvalidOperationException($"User '{recipient.UserName}' has no phone number.");

            _smsGateway.Send(toPhoneNumber, message);
        }
    }
}