using System.Collections.Generic;
int leitura = 1;
List<int> list = new List<int>();

while (leitura <= 5)
{
    int valor1 = int.Parse(Console.ReadLine());
    list.Add(valor1);
    leitura++;
}
int contagemPar = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] % 2 == 0)
    {
        contagemPar++;
    }

}

Console.WriteLine($"{contagemPar} valores pares");