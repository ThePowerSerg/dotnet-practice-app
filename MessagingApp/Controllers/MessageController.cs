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
            string message = _messageService.GetMessage();
            Console.WriteLine(message);
        }   
    }
}