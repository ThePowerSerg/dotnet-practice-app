using MessagingAPI.Data;
using MessagingAPI.Dtos;
using MessagingAPI.Models;
using MessagingAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace MessagingTests;

public class UserProfileServiceTests
{
    [Fact]
    public async Task GetUserProfileByIdAsync_ReturnsMappedDto()
    {
        var options = new DbContextOptionsBuilder<MessagingApiContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        await using var context = new MessagingApiContext(options);
        context.UserProfiles.Add(new UserProfile
        {
            Id = 1,
            UserName = "Ada Lovelace",
            Email = "ada@example.test",
            PhoneNumber = "+1-555-0100",
            Country = "United Kingdom"
        });
        await context.SaveChangesAsync();

        var service = new UserProfileService(context);

        var result = await service.GetUserProfileByIdAsync(1);

        var profile = Assert.IsType<UserProfileDto>(result);
        Assert.Equal(1, profile.Id);
        Assert.Equal("Ada Lovelace", profile.UserName);
        Assert.Equal("ada@example.test", profile.Email);
        Assert.Equal("+1-555-0100", profile.PhoneNumber);
        Assert.Equal("United Kingdom", profile.Country);
    }
}
