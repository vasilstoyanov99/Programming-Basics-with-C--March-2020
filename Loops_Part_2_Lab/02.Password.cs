using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string passInput = Console.ReadLine();
            while (pass != passInput)
            {
                passInput = Console.ReadLine();
            }

            if (pass == passInput)
            {
                Console.WriteLine($"Welcome {name}!");
            }
        }
    }
}
