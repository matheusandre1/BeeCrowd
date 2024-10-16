
double[] numeros = [7, -5, 6, -3.4, 4.6, 12];
int contagemInteiro = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > 0)
    {
        contagemInteiro++;
    }
}

Console.WriteLine($"{contagemInteiro} valores positivos");
