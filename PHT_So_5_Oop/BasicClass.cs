using System;

namespace BasicClass
{
    // Lớp Student mô tả thông tin sinh viên
    class Student
    {
        // Thuộc tính
        public string StudentId { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        // Phương thức hiển thị thông tin
        public void Display()
        {
            Console.WriteLine("MSSV: " + StudentId);
            Console.WriteLine("Tên: " + Name);
            Console.WriteLine("GPA: " + GPA);
            Console.WriteLine("----------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng sinh viên thứ nhất
            Student sv1 = new Student();
            sv1.StudentId = "SV01";
            sv1.Name = "Nguyen Hong Son";
            sv1.GPA = 3.2;

            // Tạo đối tượng sinh viên thứ hai
            Student sv2 = new Student();
            sv2.StudentId = "SV02";
            sv2.Name = "Do Hoang Phi";
            sv2.GPA = 3.8;

            // Hiển thị thông tin
            sv1.Display();
            sv2.Display();
        }
    }
}