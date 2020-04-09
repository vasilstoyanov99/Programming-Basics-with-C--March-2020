using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double TAreaRec = number * (x + 2 * 0.30) * (y + 2 * 0.30);
            double SquareLenght = y / 2;
            double TAreaSquare = number * (SquareLenght * SquareLenght);

            double DollaPrice = (TAreaRec * 7) + (TAreaSquare * 9);
            double BGPrice = DollaPrice * 1.85;

            Console.WriteLine($"{DollaPrice:f2} USD");
            Console.WriteLine($"{BGPrice:f2} BGN");

        }
    }
}
