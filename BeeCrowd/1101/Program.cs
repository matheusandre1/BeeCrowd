using System;

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] valores = Console.ReadLine().Split();

            int num1 = int.Parse(valores[0]);
            int num2 = int.Parse(valores[1]);

            if (num1 <= 0 || num2 <= 0)
            {
                break;
            }
            
                int menor = Math.Min(num1, num2);
                int maior = Math.Max(num1, num2);

                int soma = 0;

                for (int i = menor; i <= maior; i++)
                {
                        Console.Write(i + " ");
                        soma += i;
                }
                Console.WriteLine($"Sum={soma}");
        }
    }
}