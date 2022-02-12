using System;

namespace L1T3
{
    class Equations
    {
        public static double sec(double x)
        {
            return (1 / Math.Cos(x));
        }

        public static int Main()
        {
            double alpha = 0;

            Console.WriteLine("Введиите альфа: ");

            try
            {
                alpha = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            double z1 = (Math.Cos(alpha) + Math.Sin(alpha)) / (Math.Cos(alpha) - Math.Sin(alpha));
            double z2 = (Math.Tan(2 * alpha) + sec(alpha));

            Console.WriteLine("z1 = (cos@ + sin@) / (cos@ - sin@)");
            Console.WriteLine("z1 = " + z1);

            Console.WriteLine("z2 = tg@ + sec@");
            Console.WriteLine("z2 = " + z2);

            return 0;
        }
    }
}