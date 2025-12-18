using System;

namespace Encapsulation
{
    // Lớp BankAccount quản lý số dư tài khoản
    class BankAccount
    {
        // Private field lưu số dư, không cho truy cập trực tiếp từ bên ngoài
        private double _balance;

        // Property chỉ đọc, chỉ cho phép lấy giá trị số dư
        public double Balance
        {
            get { return _balance; }
        }

        // Phương thức gửi tiền
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        // Phương thức rút tiền, kiểm tra đủ số dư hay không
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Không đủ số dư để rút");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo tài khoản ngân hàng
            BankAccount account = new BankAccount();

            // Gửi tiền
            account.Deposit(1000);
            Console.WriteLine("Số dư hiện tại: " + account.Balance);

            // Rút tiền
            account.Withdraw(400);
            Console.WriteLine("Số dư sau khi rút: " + account.Balance);
        }
    }
}