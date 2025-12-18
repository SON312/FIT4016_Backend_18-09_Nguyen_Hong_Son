using System;

namespace MethodOverloading
{
    class Program
    {
        static void Print(int x)
        {
            Console.WriteLine("Print(int): " + x);
        }

        static void Print(string text)
        {
            Console.WriteLine("Print(string): " + text);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Print(10);
            Print("Hello");

            Console.WriteLine("Add(int): " + Add(3, 5));
            Console.WriteLine("Add(double): " + Add(2.5, 4.5));
        }
    }
}