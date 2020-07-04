using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var one = ConnectionSingleton.GetInstance();

            var two = ConnectionSingleton.GetInstance();

            if (one == two)
            {
                Console.WriteLine("They are same instances");
            }

            foreach (var item in one.GetConnectionStrings())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}