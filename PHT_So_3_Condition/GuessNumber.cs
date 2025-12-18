using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 50;   // Số bí mật cố định
            int guess = 0;           // Số người chơi đoán
            int attempts = 0;        // Đếm số lần đoán (tối đa 3)

            // Vòng lặp cho phép người chơi đoán tối đa 3 lần
            while (attempts < 3)
            {
                Console.Write("Nhập số bạn đoán: ");
                guess = int.Parse(Console.ReadLine());

                // So sánh số đoán với số bí mật
                if (guess < secretNumber)
                {
                    Console.WriteLine("Quá thấp");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Quá cao");
                }
                else
                {
                    Console.WriteLine("Chính xác!");
                    break; // Thoát vòng lặp khi đoán đúng
                }

                attempts++; // Tăng số lần đoán
            }
        }
    }
}