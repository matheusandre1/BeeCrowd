using System;
using System.Globalization;
namespace Exercise1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = A * C / 2;
            double circulo = pi * (C * C);
            double trapezio = ((A + B) / 2) * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
 
}