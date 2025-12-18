using System;

namespace StudentManagementSystem
{
    class Program
    {
        // Hàm Main là điểm bắt đầu của chương trình
        static void Main(string[] args)
        {
            // Tạo đối tượng quản lý sinh viên
            StudentManager manager = new StudentManager();

            // Biến kiểm soát vòng lặp menu
            bool running = true;

            // Vòng lặp hiển thị menu cho đến khi người dùng chọn thoát
            while (running)
            {
                // In menu chức năng ra màn hình
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Xóa sinh viên");
                Console.WriteLine("3. Cập nhật điểm");
                Console.WriteLine("4. In danh sách sinh viên");
                Console.WriteLine("5. Tính điểm trung bình");
                Console.WriteLine("6. Tìm điểm cao nhất");
                Console.WriteLine("7. Tìm sinh viên theo ID");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("========================");

                try
                {
                    // Nhập lựa chọn từ người dùng
                    Console.Write("Chọn chức năng: ");
                    int choice = int.Parse(Console.ReadLine());

                    // Xử lý từng lựa chọn bằng switch-case
                    switch (choice)
                    {
                        case 1:
                            // Thêm sinh viên mới
                            Console.Write("Nhập ID: ");
                            string id = Console.ReadLine();

                            Console.Write("Nhập tên: ");
                            string name = Console.ReadLine();

                            Console.Write("Nhập điểm: ");
                            double score = double.Parse(Console.ReadLine());

                            manager.AddStudent(id, name, score);
                            Console.WriteLine("Đã thêm sinh viên thành công!");
                            break;

                        case 2:
                            // Xóa sinh viên theo ID
                            Console.Write("Nhập ID sinh viên cần xóa: ");
                            manager.RemoveStudent(Console.ReadLine());
                            Console.WriteLine("Đã xóa sinh viên!");
                            break;

                        case 3:
                            // Cập nhật điểm cho sinh viên
                            Console.Write("Nhập ID sinh viên: ");
                            string sid = Console.ReadLine();

                            Console.Write("Nhập điểm mới: ");
                            double newScore = double.Parse(Console.ReadLine());

                            manager.UpdateScore(sid, newScore);
                            Console.WriteLine("Cập nhật điểm thành công!");
                            break;

                        case 4:
                            // In danh sách tất cả sinh viên
                            Console.WriteLine("\nDanh sách sinh viên:");
                            manager.DisplayAllStudents();
                            break;

                        case 5:
                            // Tính và in điểm trung bình
                            double avg = manager.GetAverageScore();
                            Console.WriteLine("Điểm trung bình: " + avg);
                            break;

                        case 6:
                            // Tìm và in điểm cao nhất
                            double max = manager.GetMaxScore();
                            Console.WriteLine("Điểm cao nhất: " + max);
                            break;

                        case 7:
                            // Tìm sinh viên theo ID
                            Console.Write("Nhập ID sinh viên cần tìm: ");
                            Student sv = manager.FindStudentById(Console.ReadLine());

                            if (sv != null)
                            {
                                sv.Display();
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy sinh viên!");
                            }
                            break;

                        case 0:
                            // Thoát chương trình
                            running = false;
                            Console.WriteLine("Đã thoát chương trình.");
                            break;

                        default:
                            // Trường hợp nhập lựa chọn không hợp lệ
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Bắt và hiển thị lỗi khi người dùng nhập sai hoặc logic sai
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }
    }
}