using MessagingApp.Controllers;
using MessagingApp.Models;

namespace MessagingApp.Views
{
    public class RunApp
    {
        // DI pattern ?
        private readonly MessageController controller;

        public RunApp(MessageController controller)
        {
            this.controller = controller;
        }

        public void Run()
        {
            var user = new UserProfile
            {
                Id = 1,
                UserName = "sferreira",
                Email = "sergferreira81@gmail.com",
                PhoneNumber = "(781) 733-2393"
            };

            controller.SendEmail(user, "Keep it flexible and DI via Email!");
            controller.SendSMS(user, "Keep it flexible and DI via SMS");
        }

        /*
           TODO - create an interface:
           1. Get the name of a user. 
           2. Send an email.
           3. Send an SMS. 
        */
        
    }
}
