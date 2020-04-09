using System;

namespace _06.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine().ToLower();
            string Output = "";
            switch (Input)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Output = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Output = "vegetable";
                    break;
                default:
                    Output = "unknown";
                    break;
            }
            Console.WriteLine(Output);
        }
    }
}
