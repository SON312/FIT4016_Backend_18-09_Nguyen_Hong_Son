using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 7;

            // Dùng switch để kiểm tra từng trường hợp
            switch (day)
            {
                case 1:
                    Console.WriteLine("Thứ Hai");
                    break;
                case 2:
                    Console.WriteLine("Thứ Ba");
                    break;
                case 3:
                    Console.WriteLine("Thứ Tư");
                    break;
                case 4:
                    Console.WriteLine("Thứ Năm");
                    break;
                case 5:
                    Console.WriteLine("Thứ Sáu");
                    break;
                case 6:
                    Console.WriteLine("Thứ Bảy");
                    break;
                case 7:
                    Console.WriteLine("Chủ Nhật");
                    break;
                default:
                    Console.WriteLine("Ngày không hợp lệ");
                    break;
            }
        }
    }
}