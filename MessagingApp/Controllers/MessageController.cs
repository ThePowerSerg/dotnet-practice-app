using MessagingApp.Models;
using MessagingApp.Services;

namespace MessagingApp.Controllers
{
    public class MessageController
    {
         private readonly IMessageService _messageService;

         public MessageController(IMessageService messageService)
         {
            _messageService = messageService;
         }

        public void Send(UserProfile recipient, string message)
        {
            _messageService.SendMessage(recipient, message);
        }
    }
}