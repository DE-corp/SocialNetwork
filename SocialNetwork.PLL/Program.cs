using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork.PLL
{
    class Program
    {
        public static UserService userService = new UserService();
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!" + Environment.NewLine);

            while (true)
            {
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                Console.Write("Введите email: ");
                string email = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = email
                };
                try
                {
                    userService.Register(userRegistrationData);
                    Console.WriteLine("Регистрация произошла успешно!" + Environment.NewLine);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введите корректное значение!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при регистрации!");
                }
            }
        }
    }
}
