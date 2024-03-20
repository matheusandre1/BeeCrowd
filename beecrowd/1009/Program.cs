using System;

namespace Exercise1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salariofix = double.Parse(Console.ReadLine());
            double totalvenda = double.Parse(Console.ReadLine());
            double comissao = totalvenda * 15 / 100;

            double salario = salariofix + comissao;
            Console.WriteLine($"TOTAL = R$ {salario.ToString("F2")}");
        }
    }
}