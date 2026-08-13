using MessagingAPI.Models;
using MessagingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessagingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfilesController(IUserProfileService userProfileService) : ControllerBase
    {
        // GET api/UserProfile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfile>>> Get()
        {
            var userProfiles = await userProfileService.GetUserProfiles();
            return Ok(userProfiles);
        }

        // Add User

        // Update User

        // Delete User

    }
}