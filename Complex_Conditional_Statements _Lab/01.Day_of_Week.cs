using System;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            string Day = "";
            switch (Num)
            {
                case 1:
                    Day = "Monday";
                    break;
                case 2:
                    Day = "Tuesday";
                    break;
                case 3:
                    Day = "Wednesday";
                    break;
                case 4:
                    Day = "Thursday";
                    break;
                case 5:
                    Day = "Friday";
                    break;
                case 6:
                    Day = "Saturday";
                    break;
                case 7:
                    Day = "Sunday";
                    break;
                default:
                    Day = "Error";
                    break;
            }
            Console.WriteLine(Day);
        }
    }
}
