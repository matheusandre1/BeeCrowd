
double valor = double.Parse(Console.ReadLine());

double[] notas = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
int[] quantidadeNotas = new int[notas.Length];

for ( int i = 0; i <= 5; i++)
{
    quantidadeNotas[i] = (int)valor / (int)notas[i];
    valor %= notas[i];
}

Console.WriteLine($"NOTAS:");
for ( int i = 0; i <= 5; i++)
{
    Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {notas[i]}.00");
}
Console.WriteLine($"MOEDas:");
for ( int i = 6; i <= 11; i++)
{
    Console.WriteLine($"{quantidadeNotas[i]} moeda(s) de {notas[i].ToString("0.00")}");
    

}