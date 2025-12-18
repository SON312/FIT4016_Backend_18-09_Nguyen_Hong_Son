using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Chuong trinh Xep loai Sinh vien ===\n");

        // TODO 1: Khai bao bien thong tin sinh vien
        string hoVaTen = "Nguyễn Hồng Sơn";
        double diem = 9;

        // TODO 2: In ra thong tin sinh vien
        Console.WriteLine($"Ho ten: {hoVaTen}");
        Console.WriteLine($"Diem: {diem}\n");

        // TODO 3: Viet cau truc if/else if/else de xep loai
        string xepLoai;

        if (diem >= 8.5)
        {
            xepLoai = "Giỏi";
        }
        else if (diem >= 7.0)
        {
            xepLoai = "Khá";
        }
        else if (diem >= 5.5)
        {
            xepLoai = "Trung bình";
        }
        else
        {
            xepLoai = "Yếu";
        }

        Console.WriteLine($"Xep loai: {xepLoai}");

        // TODO 4: Viet vong lap for de in ra bang diem cua 3 sinh vien
        string[] tenSV = { "Nguyễn Văn A", "Trần Thị B", "Lê Văn C" };
        double[] diemSV = { 8.5, 7.2, 5.8 };

        Console.WriteLine("\n=== Bang Diem ===");
        for (int i = 0; i < tenSV.Length; i++)
        {
            // TODO 5: In ra ten, diem va xep loai cua tung sinh vien
            double d = diemSV[i];
            string loai;

            if (d >= 8.5)
                loai = "Giỏi";
            else if (d >= 7.0)
                loai = "Khá";
            else if (d >= 5.5)
                loai = "Trung bình";
            else
                loai = "Yếu";

            Console.WriteLine($"{i + 1}. {tenSV[i]} - Diem: {d} - Xep loai: {loai}");
        }

        // TODO 6: (Tuy chon) Dung while loop de tinh tong diem
        double tongDiem = 0;
        int j = 0;
        while (j < diemSV.Length)
        {
            tongDiem += diemSV[j];
            j++;
        }

        Console.WriteLine($"\nTong diem: {tongDiem}");
        Console.WriteLine($"Diem trung binh: {tongDiem / diemSV.Length:F2}");
    }
}