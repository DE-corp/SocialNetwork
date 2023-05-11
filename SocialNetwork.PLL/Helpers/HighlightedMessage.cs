using System;

namespace SocialNetwork.PLL.Helpers
{
    public class HighlightedMessage
    {
        public static void Show(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
