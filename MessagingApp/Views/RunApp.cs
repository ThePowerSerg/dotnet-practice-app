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
            var userProfiles = new List<UserProfile>()
            {
                new() {
                    Id = 1,
                    UserName = "sergferreira81",
                    Email = "sergferreira81@gmail.com",
                    PhoneNumber = "7817332393"
                },
                new() { 
                    Id = 2,
                    UserName = "sergiof810",
                    Email = "sergiof810@outlook.com",
                    PhoneNumber = "7817332393"}
            };

            var user = userProfiles.Find(x => x.Id == 1);

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
