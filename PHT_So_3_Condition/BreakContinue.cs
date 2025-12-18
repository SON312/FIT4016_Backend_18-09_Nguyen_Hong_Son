using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // In các số lẻ từ 1 đến 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Bỏ qua số chẵn
                }

                // In số lẻ, không để dư khoảng trắng cuối dòng
                if (i < 19)
                    Console.Write(i + " ");
                else
                    Console.Write(i);
            }

            Console.WriteLine();

            int[] numbers = { 2, 5, 7, 1, 9, 7, 3 };

            // Tìm số 7 trong mảng
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 7)
                {
                    // +1 để hiển thị vị trí theo cách người dùng hiểu
                    Console.WriteLine("Tìm thấy số 7 tại vị trí " + (i + 1));
                    break; // Dừng ngay khi tìm thấy
                }
            }
        }
    }
}