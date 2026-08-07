using MessagingApp.Controllers;
using MessagingApp.Services;
using Microsoft.Extensions.DependencyInjection;

// 1. Set up the DI container
var services = new ServiceCollection();

// Register the interface and its implementation
services.AddTransient<IMessageService, EmailService>();

// Register the consumer class
services.AddTransient<MessageController>();

var serviceProvider = services.BuildServiceProvider();

// 2. Resolve and run
var manager = serviceProvider.GetRequiredService<MessageController>();
manager.Send(); // Output: Hello from the Email Service!
