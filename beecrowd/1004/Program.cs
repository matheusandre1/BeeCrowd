using System;

namespace Exercise1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result = x * y;
            Console.WriteLine($"PROD = {result}");
        }
    }
}