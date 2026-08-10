using MessagingApp.Controllers;
using Microsoft.Identity.Client;

namespace MessagingApp.UI
{
    public class RunApp(MessageController controller, UserProfileController userProfileController)
    {
        public void Run()
        {

            // Get User
            var user = userProfileController.GetUserProfileByID(1);

            if (user is null)
            {
                Console.WriteLine("User was not found in the database.");
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
