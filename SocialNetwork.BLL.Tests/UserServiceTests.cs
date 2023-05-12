using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using Xunit;

namespace SocialNetwork.BLL.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void RegisterMustThrowException()
        {
            UserRegistrationData userRegistrationData = new UserRegistrationData()
            {
                Email = "sssdasd",
                FirstName = "",
                LastName = "Иванов",
                Password = "1234567"
            };

            var userService = new UserService();

            Assert.Throws<ArgumentNullException>(delegate
            {
                userService.Register(userRegistrationData);
            });
        }
    }
}
