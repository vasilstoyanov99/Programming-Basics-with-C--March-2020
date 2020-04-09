using System;

namespace _09.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double commission = double.Parse(Console.ReadLine());
            double percentage = 0.00;
            bool isTrue = true;
            if(town == "Sofia")
            {
                if (commission > 0 && commission <= 500)
                {
                    percentage += 0.05;
                    Console.WriteLine($"{commission * percentage:f2}");
                }
                else if (commission > 500 && commission <= 1000)
                {
                    percentage += 0.07;
                    Console.WriteLine($"{commission * percentage:f2}");
                }
                else if (commission > 1000 && commission <= 10000)
                {
                    percentage += 0.08;
                    Console.WriteLine($"{commission * percentage:f2}");
                }
                else if (commission > 10000)
                {
                    percentage += 0.12;
                    Console.WriteLine($"{commission * percentage:f2}");
                }
                else
                    isTrue = false;
            }
            else if (town == "Varna")
            {
                        if (commission > 0 && commission <= 500)
                        {
                            percentage += 0.045;
                            Console.WriteLine($"{commission * percentage:f2}");
                        }
                        else if (commission > 500 && commission <= 1000)
                        {
                            percentage += 0.075;
                            Console.WriteLine($"{commission * percentage:f2}");
                        }
                        else if (commission > 1000 && commission <= 10000)
                        {
                            percentage += 0.10;
                            Console.WriteLine($"{commission * percentage:f2}");
                        }
                        else if (commission > 10000)
                        {
                            percentage += 0.13;
                            Console.WriteLine($"{commission * percentage:f2}");
                        }
                        else
                            isTrue = false;
            }
            else if (town == "Plovdiv")
            {
                                        if (commission > 0 && commission <= 500)
                                        {
                                            percentage += 0.055;
                                            Console.WriteLine($"{commission * percentage:f2}");
                                        }
                                        else if (commission > 500 && commission <= 1000)
                                        {
                                            percentage += 0.08;
                                            Console.WriteLine($"{commission * percentage:f2}");
                                        }
                                        else if (commission > 1000 && commission <= 10000)
                                        {
                                            percentage += 0.12;
                                            Console.WriteLine($"{commission * percentage:f2}");
                                        }
                                        else if (commission > 10000)
                                        {
                                            percentage += 0.145;
                                            Console.WriteLine($"{commission * percentage:f2}");
                                        }
                                        else
                                            isTrue = false;
            }
            else isTrue = false;
            if (!isTrue)
            Console.WriteLine("error");
        }
    }
}
