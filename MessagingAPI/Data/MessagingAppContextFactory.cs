using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;

namespace MessagingAPI.Data
{
    // Used only by the `dotnet ef` CLI at design time (e.g. migrations add/update).
    // The tool can't build the app's normal Host/DI container (Program.cs never
    // calls host.Run()/RunAsync(), which is what it hooks into), so it falls back
    // to any IDesignTimeDbContextFactory<T> it finds instead.
    // public class MessagingApiContextFactory : IDesignTimeDbContextFactory<MessagingApiContext>
    // {
    //     public MessagingApiContext CreateDbContext(string[] args)
    //     {
    //         var configuration = new ConfigurationBuilder()
    //             .SetBasePath(Directory.GetCurrentDirectory())
    //             .AddJsonFile("appsettings.json", optional: false)
    //             .AddUserSecrets<MessagingApiContextFactory>(optional: true)
    //             .Build();

    //         var connectionString =
    //             configuration.GetConnectionString("DefaultConnection")
    //                 ?? throw new InvalidOperationException("Connection string"
    //                 + "'DefaultConnection' not found.");

    //         var optionsBuilder = new DbContextOptionsBuilder<MessagingApiContext>();
    //         optionsBuilder
    //             .UseSqlServer(connectionString)
    //             .UseSeeding(DbInitializer.SeedData);

    //         return new MessagingApiContext(optionsBuilder.Options);
    //     }
    // }
}
