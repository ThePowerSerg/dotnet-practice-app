using MessagingApp.Controllers;
using MessagingApp.Models;

namespace MessagingApp.Views
{
    public class RunApp
    {
        private readonly MessageController controller;

        public RunApp(MessageController controller)
        {
            this.controller = controller;
        }

        public void Run()
        {
            

            //controller.SendEmail(user, "Keep it flexible and DI via Email!");
            //controller.SendSMS(user, "Keep it flexible and DI via SMS");
        }

        /*
           TODO - create an interface:
           1. Search the user by name and get email/phone number. 
           2. Send an email.
           3. Send an SMS. 
        */
        
    }
}
