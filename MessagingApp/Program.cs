using MessagingApp.Controllers;
using MessagingApp.Models;
using MessagingApp.Services;
using Microsoft.Extensions.DependencyInjection;

// 1. Set up the DI container
var services = new ServiceCollection();

// Register the interface and its implementation
services.AddTransient<IEmailService, EmailService>();
services.AddTransient<ISMSService, SMSService>();

// Register the consumer class
services.AddTransient<MessageController>();

// 2. Resolve and run
var serviceProvider = services.BuildServiceProvider();
var controller = serviceProvider.GetRequiredService<MessageController>();


// Move data to respective folder
var user = new UserProfile
{
    Id = 1,
    UserName = "sferreira",
    Email = "sergferreira81@gmail.com",
    PhoneNumber = "(781) 733-2393"
};

// Run the app from dedicate class
controller.SendEmail(user, "Keep it flexible and DI via Email!");
controller.SendSMS(user, "Keep it flexible and DI via SMS");
