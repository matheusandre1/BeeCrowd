

 int valores = 1;
int quantidadePar = 0;
int quantidadeImpar = 0;
int numPositivo = 0;
int numNegativo = 0;

List<int> lista = new List<int>();
int entradaDeDados;
while (valores <= 5)
{
    entradaDeDados = int.Parse(Console.ReadLine());
    lista.Add(entradaDeDados);
    valores++;
}

for (int i = 0; i < lista.Count; i++)
{
    if (lista[i] == 0)
    {
        quantidadePar++;
    }
    else if (lista[i] > 0)
    {
        numPositivo++;
        if (lista[i] % 2 == 0)
        {
            quantidadePar++;
        }
        else
        {
            quantidadeImpar++;
        }
    }
    else if (lista[i] < 0)
    {
        numNegativo++;

        if (lista[i] % 2 == 0)
        {
            quantidadePar++;
        }
        else
        {
            quantidadeImpar++;
        }
    }


}

Console.WriteLine($"{quantidadePar} valor(es) par(es)");
Console.WriteLine($"{quantidadeImpar} valor(es) impar(es)");
Console.WriteLine($"{numPositivo} valor(es) positivo(s)");
Console.WriteLine($"{numNegativo} valor(es) negativo(s)");

