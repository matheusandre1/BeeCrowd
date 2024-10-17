
int valor = int.Parse(Console.ReadLine());
int leituraDeDados;
int leitura = 0;
int dentroDoIntervalo = 0;
int foradoIntervalo = 0;
List<int> lista = new List<int>();
while (valor > leitura)
{
    leituraDeDados = int.Parse(Console.ReadLine());
    lista.Add(leituraDeDados);
    leitura++;

}

foreach (var item in lista)
{
    if (item >= 10 && item <= 20)
    {
        dentroDoIntervalo++;
    }
    else
    {
        foradoIntervalo++;
    }
    
}

Console.WriteLine($"{dentroDoIntervalo} in");
Console.WriteLine($"{foradoIntervalo} out");