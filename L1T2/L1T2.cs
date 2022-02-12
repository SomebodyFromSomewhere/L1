using System;

namespace L1T2
{
    public class Info
    {
        public static void PrintOsVersion()
        {
            var os = Environment.OSVersion;
            Console.WriteLine("Информация о текущей ОС:\n");
            Console.WriteLine("Платформа: {0:G}", os.Platform);
            Console.WriteLine("Версия: {0}", os.VersionString);
            Console.WriteLine("Информация о версии:");
            Console.WriteLine("   Основная: {0}", os.Version.Major);
            Console.WriteLine("   Второстепенная: {0}", os.Version.Minor);
            Console.WriteLine("Пакет обновления: '{0}'", os.ServicePack);
        }

        public static int Main()
        {
            PrintOsVersion();

            return 0;
        }
    }
}