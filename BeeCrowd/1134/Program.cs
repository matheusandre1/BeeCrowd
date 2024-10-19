
int contagemAlcool = 0;
int contagemGasolina = 0;
int contagemDiesel = 0;
int numeroLido = 0;
do
{
    numeroLido = int.Parse(Console.ReadLine());

    if (numeroLido == 1)
    {
        contagemAlcool++;
    }

    if (numeroLido == 2)
    {
        contagemGasolina++;
    }

    if (numeroLido == 3)
    {
        contagemDiesel++;
    }

} while (numeroLido != 4);

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {contagemAlcool}");
Console.WriteLine($"Gasolina: {contagemGasolina}");
Console.WriteLine($"Diesel: {contagemDiesel}");