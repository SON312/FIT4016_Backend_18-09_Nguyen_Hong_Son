using System;

namespace SumCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            // Cộng các số từ 1 đến 100
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("Tổng các số từ 1 đến 100: " + sum);
        }
    }
}