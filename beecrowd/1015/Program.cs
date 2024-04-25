using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            float x1 = float.Parse(p1[0]);
            float y1 = float.Parse(p1[1]);

            string[] p2 = Console.ReadLine().Split(' ');
            float x2 = float.Parse(p2[0]);
            float y2 = float.Parse(p2[1]);


           double resultotal = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2));

            Console.WriteLine(resultotal.ToString("F4"));
        }
    }
}