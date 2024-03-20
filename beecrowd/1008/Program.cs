using System;

namespace Exercise1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionario = int.Parse(Console.ReadLine());
            int horastrab = int.Parse(Console.ReadLine());
            double valorRecebido = double.Parse(Console.ReadLine());

            double salarioCalculado = horastrab * valorRecebido;
            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U$ {salarioCalculado.ToString("F2")}");
        }
    }
}