using MessagingApp.Controllers;
using MessagingApp.Data;
using MessagingApp.Services;
using MessagingApp.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

// 1. Set up the DI container
var builder = Host.CreateApplicationBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddDbContext<MessagingAppContext>(options =>
    options.UseSqlServer(connectionString));

// Register the interface and its implementation
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<ISMSService, SMSService>();
// Register the consumer class
builder.Services.AddTransient<MessageController>();

// Register the app runner
builder.Services.AddTransient<RunApp>();

// 2. Build the host
using var host = builder.Build();

// Seed the database - run manually as needed, comment out otherwise
using var seedContext = new MessagingAppContextFactory().CreateDbContext([]);
DbInitializer.SeedData(seedContext);

// 3. Resolve and run
var app = host.Services.GetRequiredService<RunApp>();
app.Run();
