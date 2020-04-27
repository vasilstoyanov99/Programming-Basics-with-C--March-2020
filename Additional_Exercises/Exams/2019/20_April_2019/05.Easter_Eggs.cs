using System;

namespace _05.Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggsNum = int.Parse(Console.ReadLine());
            int redPainted = 0;
            int orangePainted = 0;
            int bluePainted = 0;
            int greenPainted = 0;
            int maxEggs = 0;
            string typeMostUsedPaint = "";

            for (int currentEgg = 0; currentEgg < paintedEggsNum; currentEgg++)
            {
                string typeOfColour = Console.ReadLine();

                switch (typeOfColour)
                {
                    case "red":
                        redPainted++;
                        break;
                    case "orange":
                        orangePainted++;
                        break;
                    case "blue":
                        bluePainted++;
                        break;
                    case "green":
                        greenPainted++;
                        break;
                }
            }

            if (redPainted > orangePainted && redPainted > bluePainted)
            {
                if (redPainted > greenPainted)
                {
                    maxEggs = redPainted;
                    typeMostUsedPaint = "red";
                }
            }
            else if (orangePainted > redPainted && orangePainted > bluePainted)
            {
                if (orangePainted > greenPainted)
                {
                    maxEggs = orangePainted;
                    typeMostUsedPaint = "orange";
                }
            }
            else if (bluePainted > redPainted && bluePainted > orangePainted)
            {
                if (bluePainted > greenPainted)
                {
                    maxEggs = bluePainted;
                    typeMostUsedPaint = "blue";
                }
            }
            else if (greenPainted > redPainted && greenPainted > orangePainted)
            {
                if (greenPainted > bluePainted)
                {
                    maxEggs = greenPainted;
                    typeMostUsedPaint = "green";
                }
            }

            Console.WriteLine($"Red eggs: {redPainted}");
            Console.WriteLine($"Orange eggs: {orangePainted}");
            Console.WriteLine($"Blue eggs: {bluePainted}");
            Console.WriteLine($"Green eggs: {greenPainted}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {typeMostUsedPaint}");
        }
    }
}
