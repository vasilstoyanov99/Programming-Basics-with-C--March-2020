using System;

namespace _03.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double Age = double.Parse(Console.ReadLine());
            string  Gender = Console.ReadLine();
            string Outcome = "";
            if(Gender == "m")
            {
                if (Age >= 16)
                    Outcome = "Mr.";
                else
                    Outcome = "Master";
            }
            else if(Gender == "f")
            {
                if (Age >= 16)
                    Outcome = "Ms.";
                else
                    Outcome = "Miss";
            }
            Console.WriteLine(Outcome);
        }
    }
}
