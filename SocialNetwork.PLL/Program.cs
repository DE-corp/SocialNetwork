﻿using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using SocialNetwork.PLL.Views;
using System;

namespace SocialNetwork.PLL
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        static FriendService friendService;

        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static AddFriendView addFriendView;
        public static UserFriendsView userFriendsView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            addFriendView = new AddFriendView(friendService);
            userFriendsView = new UserFriendsView();

            while (true)
            {
                HighlightedMessage.Show(Environment.NewLine + "Добро пожаловать в социальную сеть!" + Environment.NewLine);
                mainView.Show();
            }
        }
    }
}

