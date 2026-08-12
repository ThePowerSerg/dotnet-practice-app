using MessagingAPI.Contollers;
using MessagingAPI.Data;
using MessagingAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Layer in user-secrets explicitly (rather than relying on the Development-only
// auto-load behavior) so ConnectionStrings:DefaultConnection - deliberately left
// blank in appsettings.json - resolves from the secret store instead.
builder.Configuration.AddUserSecrets<Program>();

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddDbContext<MessagingApiContext>(options =>
    options.UseSqlServer(connectionString));

// Register the interface and its implementation
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<ISMSService, SMSService>();
builder.Services.AddTransient<IBookService, BookService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
