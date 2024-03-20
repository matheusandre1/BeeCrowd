using System;

namespace Exercise1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = float.Parse(Console.ReadLine());
            double B = float.Parse(Console.ReadLine());
            double  media = ((A * 3.5 + B * 7.5) / 11);

            Console.WriteLine($"MEDIA = {media.ToString("F5")}");
        }
    }
}
