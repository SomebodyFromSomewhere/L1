using System;

namespace L1T1
{
    class Greet
    {
        public static int Main()
        {
            Console.WriteLine("Введите имя: ");
            string input = Console.ReadLine(); //Можно ли как нибуть убрать ошибку CS8600 и её следствие CS8604, кромя способа с warning disable?

            Console.WriteLine("Здравствуйте " + input + ".");

            return 0;
        }
    }
}