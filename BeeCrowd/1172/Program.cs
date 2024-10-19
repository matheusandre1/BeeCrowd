
int[] numerosInteiros = new int[10];


int leitura;
for (int i = 0; i < numerosInteiros.Length; i++)
{
    leitura = int.Parse(Console.ReadLine());    
    
    numerosInteiros[i] = leitura;

    if (numerosInteiros[i] <= 0)
    {
        numerosInteiros[i] = 1;
    }    
}

for (int i = 0; i < numerosInteiros.Length; i++)
{
    Console.WriteLine($"X[{i} = {numerosInteiros[i]}");    
}

