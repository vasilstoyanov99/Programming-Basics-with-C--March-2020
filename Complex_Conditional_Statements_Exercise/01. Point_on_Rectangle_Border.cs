using System;

namespace _01._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isBorder = false;

            if (x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    isBorder = true;
                }
            }
            if(y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    isBorder = true;
                }
            }
            if(isBorder == true)
                Console.WriteLine("Border");
            else if (isBorder == false)
                Console.WriteLine("Inside / Outside");
        }
    }
}
