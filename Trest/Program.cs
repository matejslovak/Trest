using System;

namespace Trest
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();

            while (true)
            {
                storage.Update();
                Console.WriteLine("Which battery do you want to charge ?");
                string input = Console.ReadLine();
                storage.Recharge(input, 3);
            }
        }
    }
}