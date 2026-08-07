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

        public void Send()
        {
            _messageService.Message = "Keep it flexible with DI!";

            _messageService.SendMessage();
        }   
    }
}