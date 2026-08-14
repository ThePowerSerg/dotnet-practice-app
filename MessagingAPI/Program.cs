using MessagingAPI.Data;
using MessagingAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// TODO: setup secrets
//builder.Configuration.AddUserSecrets<Program>();

// register DbContext and define options
builder.Services.AddDbContext<MessagingApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    .UseSeeding(DbInitializer.SeedData);
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Register the interface and its implementation
builder.Services.AddScoped<IUserProfileService, UserProfileService>();
// Practice service 
builder.Services.AddScoped<IBookService, BookService>();

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
