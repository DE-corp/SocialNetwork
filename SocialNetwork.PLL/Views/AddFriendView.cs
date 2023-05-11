using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        FriendService friendService;

        public AddFriendView(FriendService friendService)
        {
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            try
            {
                Console.Write("Введи почтовый ящик друга: ");

                var addFriendData = new AddFriendData()
                {
                    FriendEmail = Console.ReadLine(),
                    UserId = user.Id
                };

                friendService.AddFriend(addFriendData);
                SuccessMessage.Show("Новый друг успешно добавлен");
            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("Email друга введен некорректно!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }


        }
    }
}
