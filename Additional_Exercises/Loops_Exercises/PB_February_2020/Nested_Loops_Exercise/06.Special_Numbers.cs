using System;

namespace _06.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int currentSpecialNum = 1111; currentSpecialNum <= 9999; currentSpecialNum++)
            {
                string specialNumStr = currentSpecialNum.ToString();
                int IsTrueCounter = 0;
                for (int currentChar = 0; currentChar < specialNumStr.Length; currentChar++)
                {
                    int currentDevider = int.Parse(specialNumStr[currentChar].ToString());

                    if (currentDevider == 0)
                    {
                        continue;
                    }

                    if (N % currentDevider == 0)
                    {
                        IsTrueCounter++;
                    }
                }

                if (IsTrueCounter == 4)
                {
                    Console.Write($"{currentSpecialNum} ");
                }
            }
        }
    }
}
