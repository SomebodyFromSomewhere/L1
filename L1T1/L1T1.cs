using System;

namespace L1T1
{
    class Greet
    {
        public static void GreetUser(string userName)
        {
            if (userName == null || userName == "")
            {
                userName = "Unknown";
            }

            Console.WriteLine("Здравствуйте " + userName + ".");
        }
        public static int Main()
        {
            Console.WriteLine("Введите имя: ");
            string input = Console.ReadLine(); //Можно ли как нибуть убрать ошибку CS8600 и её следствие CS8604, кромя способа с warning disable?

            GreetUser(input);

            return 0;
        }
    }
}