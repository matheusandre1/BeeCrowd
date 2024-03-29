using System;
using System.Globalization;

namespace Exercise1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigopeca1 = int.Parse(Console.ReadLine());
            int numeropeca1 = int.Parse(Console.ReadLine());
            double valorpeca1 = double.Parse(Console.ReadLine());

            int codigopeca2 = int.Parse(Console.ReadLine());
            int numeropeca2 = int.Parse(Console.ReadLine());
            double valorpeca2 = double.Parse(Console.ReadLine());

            double result = (numeropeca1 * valorpeca1) + (numeropeca2 * valorpeca2);

            Console.WriteLine($"Valor a Pagar: R$ {result.ToString("F",CultureInfo.InvariantCulture)}");
        }
    }
}