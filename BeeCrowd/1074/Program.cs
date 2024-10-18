int quantidadeValoresLidos = int.Parse(Console.ReadLine());

int leitura = 0;
List<int> valores = new List<int>();

int valorLido;
  while ( quantidadeValoresLidos > leitura)
{
    valorLido = int.Parse(Console.ReadLine());
    valores.Add(valorLido);
    leitura++;
}

foreach (int valor in valores)
{
    if (valor < 0 && valor % 2 != 0)
    {
        Console.WriteLine("ODD NEGATIVE");
    }
    else if (valor > 0 && valor % 2 != 0)
    {
        Console.WriteLine("ODD POSITIVE");
    }

    if (valor == 0)
    {
        Console.WriteLine("NULL");
    }
    else if(valor < 0 && valor % 2 == 0)
    {
        Console.WriteLine("EVEN NEGATIVE");
    }
    else if (valor > 0 && valor % 2 == 0)
    {
        Console.WriteLine("EVEN POSITIVE");
    }
}

