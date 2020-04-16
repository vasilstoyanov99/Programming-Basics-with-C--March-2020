using System;

namespace _01.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNaylon = int.Parse(Console.ReadLine());
            int neededPaintLiters = int.Parse(Console.ReadLine());
            int neededPaintDiluent = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double naylonExpenses = (neededNaylon + 2) * 1.50;
            double paintExpenses = (neededPaintLiters * 1.10) * 14.50;
            double paintDiluentExpenses = neededPaintDiluent * 5.00;
            double bagsExpenses = 0.40;
            double totalMaterialsExpenses = naylonExpenses + paintExpenses + paintDiluentExpenses + bagsExpenses;
            double workersPayment = totalMaterialsExpenses * 0.30;
            double totalExpenses = totalMaterialsExpenses + (workersPayment * workHours);

            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");
        }
    }
}
