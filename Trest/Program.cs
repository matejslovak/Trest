using System;

namespace Trest
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new storage();

            while (true)
            {
                storage.Update();
                Console.WriteLine("Which battery do you want to charge ?");
                string input = Console.ReadLine();
                storage.recharge(input, 3);
            }
        }
    }
}