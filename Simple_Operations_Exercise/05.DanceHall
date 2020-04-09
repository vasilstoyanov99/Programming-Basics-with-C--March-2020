using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double TotalCakes = confectioner * cakes * days * 45.0;
            double TotalWaffles = confectioner * waffles * days * 5.80;
            double TotalPancakes = confectioner * pancakes * days * 3.20;
            double MoneyForSweets = (TotalPancakes + TotalWaffles + TotalCakes) * 0.125;
            double CharityMoney = TotalPancakes + TotalWaffles + TotalCakes - MoneyForSweets;

            Console.WriteLine($"{CharityMoney:f2}");

        }
    }
}
