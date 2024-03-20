using System;
using System.Globalization;

namespace Exercise1000
{
    class Program
    {
        static void Main(string[] args)
        {
            float  area = float.Parse(Console.ReadLine()!);
            float result = (float)((area * 2) * Math.PI);
            Console.WriteLine(result.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}