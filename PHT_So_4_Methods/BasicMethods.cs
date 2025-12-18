using System;

namespace BasicMethods
{
    class Program
    {
        // Phương thức tính tổng 2 số nguyên
        static int Add(int a, int b)
        {
            return a + b; // Trả về tổng
        }

        // Phương thức tính tích 2 số thực
        static double Multiply(double x, double y)
        {
            return x * y; // Trả về tích
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tổng: " + Add(5, 3));
            Console.WriteLine("Tích: " + Multiply(2.5, 4));
        }
    }
}