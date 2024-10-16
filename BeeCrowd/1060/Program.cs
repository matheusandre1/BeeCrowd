
double[] numeros = [7, -5, 6, -3.4, 4.6, 12];
int contagemPositivo = 0;
foreach (var item in numeros)
{
    if (item > 0){
        contagemPositivo += 1;
    }
    
}

Console.WriteLine($"{contagemPositivo} valores positivos");