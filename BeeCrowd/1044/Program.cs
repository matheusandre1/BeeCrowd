string[] valores = Console.ReadLine().Split(' ');

int num1 = int.Parse(valores[0]);
int num2 = int.Parse(valores[1]);

if (num1 % num2 != 0 && num2 % num1 != 0)
{
    Console.WriteLine("Nao sao Multiplos");
}
else
{
    Console.WriteLine("Sao Multiplos");
}
