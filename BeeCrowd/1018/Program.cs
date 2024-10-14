
using System.Globalization;

int dinheiro = int.Parse(Console.ReadLine());
int dinheiroInicial = dinheiro;

int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
int[] quantidadeNotas = new int[notas.Length];

for (int i = 0; i < notas.Length; i++)
{
    quantidadeNotas[i] = dinheiro / notas[i];  
    dinheiro %= notas[i];
}

Console.WriteLine(dinheiroInicial);
for (int i = 0; i < notas.Length; i++)
{   
   Console.WriteLine($"{quantidadeNotas[i]} nota(s) de R$ {notas[i]},00");
    
}