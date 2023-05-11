using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendsView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine(Environment.NewLine + "Ваши друзья: " + Environment.NewLine);

            if (friends.Count() == 0)
            {
                HighlightedMessage.Show("У вас нет друзей");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                HighlightedMessage.Show($"Email друга: {friend.Email}. Имя друга: {friend.FirstName}. Фамилия друга: {friend.LastName}");

            });
        }
    }
}
