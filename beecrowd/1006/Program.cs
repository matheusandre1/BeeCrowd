﻿using System;

namespace Exercise1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double media = (a  * 2.0 + b * 3.0 + c * 5) / 10;
            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }
}
