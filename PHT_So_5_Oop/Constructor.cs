using System;

namespace Constructor
{
    // Lớp Product có constructor
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Constructor khởi tạo dữ liệu
        public Product(string productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        // Hiển thị thông tin sản phẩm
        public void Display()
        {
            Console.WriteLine("Mã SP: " + ProductId);
            Console.WriteLine("Tên SP: " + ProductName);
            Console.WriteLine("Giá: " + Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng bằng constructor
            Product p = new Product("P01", "Laptop", 1500);

            // In thông tin
            p.Display();
        }
    }
}