using MessagingApp.Controllers;
using MessagingApp.Data;
using MessagingApp.Services;
using MessagingApp.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

// 1. Set up the DI container
var services = new ServiceCollection();

var builder = Host.CreateApplicationBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

services.AddDbContext<MessagingAppContext>(options =>
    options.UseSqlServer(connectionString));

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
