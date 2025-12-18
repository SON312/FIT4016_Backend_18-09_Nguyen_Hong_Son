using System;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "Mai", "Bình", "Chi", "Danh" };
            int index = 1; // Biến đếm để đánh số thứ tự

            // Duyệt từng phần tử trong mảng bằng foreach
            foreach (string name in friends)
            {
                Console.WriteLine(index + ". " + name);
                index++; // Tăng số thứ tự sau mỗi lần in
            }
        }
    }
}