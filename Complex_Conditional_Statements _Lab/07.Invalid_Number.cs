using System;

namespace _07.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            bool isTrue = true;
            if((Num >= 100 && Num <= 200) || Num == 0)
                isTrue = true;
            else
                isTrue = !true;
            if(!isTrue)
                Console.WriteLine("invalid");
        }
    }
}
