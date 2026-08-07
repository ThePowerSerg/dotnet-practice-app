using MessagingApp.Controllers;
using MessagingApp.Models;
using MessagingApp.Services;
using Microsoft.Extensions.DependencyInjection;

// 1. Set up the DI container
var services = new ServiceCollection();

// Register the interface and its implementation
services.AddTransient<IMessageService, EmailService>();

// Register the consumer class
services.AddTransient<MessageController>();

// 2. Resolve and run
var serviceProvider = services.BuildServiceProvider();
var manager = serviceProvider.GetRequiredService<MessageController>();

var recipient = new UserProfile
{
    Id = 1,
    UserName = "sferreira",
    Email = "sergferreira81@gmail.com",
    PhoneNumber = "+15555555555"
};

manager.Send(recipient, "Keep it flexible and DI!"); // Output: Emailing sergferreira81@gmail.com: Keep it flexible with DI!
