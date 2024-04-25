using System;
using System.Globalization;

namespace Exercise1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()!);
            double y = double.Parse(Console.ReadLine()!);

            double result = x / y;
            Console.WriteLine($"{result.ToString("F3",CultureInfo.InvariantCulture)} km/l");

        }
    }
}