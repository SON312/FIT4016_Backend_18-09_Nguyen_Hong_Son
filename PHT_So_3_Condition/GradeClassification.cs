using System;

namespace GradeClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập điểm (giả sử)
            int score = 95;

            // Phân loại điểm dựa trên thang điểm
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Xếp loại: A (Xuất sắc)");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Xếp loại: B (Khá)");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Xếp loại: C (Trung bình)");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Xếp loại: D (Yếu)");
            }
            else
            {
                Console.WriteLine("Xếp loại: F (Không đạt)");
            }
        }
    }
}