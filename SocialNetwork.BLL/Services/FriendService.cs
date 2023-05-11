using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IUserRepository userRepository;
        IFriendRepository friendRepository;

        public FriendService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        public IEnumerable<FriendEntity> GetFriendsByUserId(int userId)
        {
            return friendRepository.FindAllByUserId(userId);
        }

        public void AddFriend(AddFriendData addFriendData)
        {
            if (String.IsNullOrEmpty(addFriendData.FriendEmail)) throw new ArgumentNullException();
            if (!new EmailAddressAttribute().IsValid(addFriendData.FriendEmail)) throw new ArgumentNullException();

            var findUserEntity = userRepository.FindByEmail(addFriendData.FriendEmail);

            if (findUserEntity is null)
                throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = addFriendData.UserId,
                friend_id = findUserEntity.id
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }
    }
}
