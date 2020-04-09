using System;

namespace _06.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pass = Console.ReadLine();
            string Password = "s3cr3t!P@ssw0rd";
            if (Pass == Password)
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
