using MessagingApp.Models;

namespace MessagingApp.Data
{
    public class DbInitializer
    {
        public void CreateUserList()
        {
            var UserList = new List<UserProfile>()
            {
                new() {
                    Id = 1,
                    UserName = "sergferreira81",
                    Email = "sergferreira81@gmail.com",
                    PhoneNumber = "7817332393"
                },
                new() { 
                    Id = 2,
                    UserName = "sergiof810",
                    Email = "sergiof810@outlook.com",
                    PhoneNumber = "7817332393"}
            };
        }
    }
}