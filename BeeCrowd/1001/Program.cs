using System;

namespace Projetc
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());

            int result = A + B;

            Console.WriteLine($"x = {result}");
        }
    }
}