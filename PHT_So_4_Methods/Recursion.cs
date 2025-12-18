using System;

namespace Recursion
{
    class Program
    {
        static long Factorial(int n)
        {
            // Kiểm tra dữ liệu không hợp lệ
            if (n < 0)
            {
                throw new ArgumentException("n phải >= 0");
            }

            // Điều kiện dừng
            if (n == 0)
            {
                return 1;
            }

            // Gọi đệ quy
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("5! = " + Factorial(5));
            Console.WriteLine("10! = " + Factorial(10));
        }
    }
}