using MessagingApp.Controllers;
using MessagingApp.Data;

namespace MessagingApp.Views
{
    public class RunApp
    {
        private readonly MessageController controller;
        private readonly MessagingAppContext context;

        public RunApp(MessageController controller, MessagingAppContext context)
        {
            this.controller = controller;
            this.context = context;
        }

        public void Run()
        {
            var user = context.UserProfiles.FirstOrDefault(x => x.UserName == "sergferreira81");

            if (user is null)
            {
                Console.WriteLine("User 'sergferreira81' was not found in the database.");
                return;
            }

            controller.SendEmail(user, "Keep it flexible and DI via Email!");
            controller.SendSMS(user, "Keep it flexible and DI via SMS");
        }

        /*
           TODO - create an interface:
           1. Search the user by name and get email/phone number.
           2. Send an email.
           3. Send an SMS.
        */

    }
}
