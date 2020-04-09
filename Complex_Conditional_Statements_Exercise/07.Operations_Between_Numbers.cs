using System;

namespace _07.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operato = Console.ReadLine();
            double result = 0.00;
            bool isEven = false;
            switch (operato)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                        break;
                    }
                    else
                    {
                        result = n1 / n2;
                        break;
                    }
                case "%":
                    if(n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                        break;
                    }
                    else
                    {
                        result = n1 % n2;
                        break;
                    }      
            }
            switch (operato)
            {
                case "+":
                case "-":
                case "*":
                    if (result % 2 == 0)
                        isEven = true;
                    if(isEven == true)
                    Console.WriteLine($"{n1} {operato} {n2} = {Math.Truncate(result)} - even");
                    else
                        Console.WriteLine($"{n1} {operato} {n2} = {Math.Truncate(result)} - odd");
                    break;
                case "/":
                    if(n2 != 0)
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    break;
                case "%":
                    if (n2 != 0)
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    break;
            }

        }
    }
}
