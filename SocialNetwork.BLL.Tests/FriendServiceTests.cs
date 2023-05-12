using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using Xunit;

namespace SocialNetwork.BLL.Tests
{
    public class FriendServiceTests
    {
        [Fact]
        public void AddFriendMustThrowException()
        {
            var addFriendData = new AddFriendData()
            {
                FriendEmail = "dfffff",
                UserId = 7
            };

            var friendService = new FriendService();

            Assert.Throws<ArgumentNullException>(delegate
            {
                friendService.AddFriend(addFriendData);
            });
        }
    }
}
