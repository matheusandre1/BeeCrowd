int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int soma = 0;

int menor = Math.Min(num1, num2);
int maior = Math.Max(num1, num2);
for (int i = menor; i <= maior; i++)
{
    if (i % 13 != 0)
    {
        soma += i;
    }
}
Console.WriteLine(soma);