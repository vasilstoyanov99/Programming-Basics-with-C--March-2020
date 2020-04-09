using System;

namespace _08.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double apartmentPrice = 0.00;
            double studioPrice = 0.00;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice += 50.00;
                    apartmentPrice += 65.00;
                    break;
                case "June":
                case "September":
                    studioPrice += 75.20;
                    apartmentPrice += 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice += 76.00;
                    apartmentPrice += 77.00;
                    break;
            }
            if (numNights > 14)
                apartmentPrice *= 0.90;
            switch (month)
            {
                case "May":
                case "October":
                    if (numNights > 7 && numNights < 14)
                        studioPrice *= 0.95;
                    if (numNights > 14)
                        studioPrice *= 0.70;
                    break;
                case "June":
                case "September":
                    if(numNights > 14)
                    studioPrice *= 0.80;
                    break;
            }
            Console.WriteLine($"Apartment: {apartmentPrice * numNights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice * numNights:f2} lv.");
        }
    }
}
