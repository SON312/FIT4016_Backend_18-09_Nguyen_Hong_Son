using System;

namespace VoidMethods
{
    class Program
    {
        static void PrintBox(string text)
        {
            // Tính độ dài khung dựa trên độ dài chuỗi
            int boxWidth = text.Length + 4;

            // In dòng trên
            Console.WriteLine(new string('*', boxWidth));

            // In dòng chứa nội dung
            Console.WriteLine("* " + text + " *");

            // In dòng dưới
            Console.WriteLine(new string('*', boxWidth));
        }

        static void Main(string[] args)
        {
            PrintBox("Hello");
            PrintBox("CSharp");
        }
    }
}