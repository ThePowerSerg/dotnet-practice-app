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
    }
}
