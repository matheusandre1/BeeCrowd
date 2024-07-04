using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] p1 = Console.ReadLine().Split(' ');
            int A = int.Parse((p1[0]));
            int B = int.Parse((p1[1]));
            int C = int.Parse((p1[2]));
            int D = int.Parse((p1[3]));

            if(B > C && D > A && (C + D) > A + B && (C > 0) && (D > 0) && (A % 2 == 0))
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }

    }
}