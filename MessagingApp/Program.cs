using MessagingApp.Controllers;
using MessagingApp.Services;
using MessagingApp.Views;
using Microsoft.Extensions.DependencyInjection;

// 1. Set up the DI container
var services = new ServiceCollection();

// Register the interface and its implementation
services.AddTransient<IEmailService, EmailService>();
services.AddTransient<ISMSService, SMSService>();

// Register the consumer class
services.AddTransient<MessageController>();

// Register the app runner
services.AddTransient<RunApp>();

// 2. Resolve and run
var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetRequiredService<RunApp>();

// 3. Run the app
app.Run();
