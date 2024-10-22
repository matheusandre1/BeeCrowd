
int X;
int Y;
do
{
    string[] numeros = Console.ReadLine().Split(' ');

    X = int.Parse(numeros[0]);
    Y = int.Parse(numeros[1]);

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("quarto");
    }
} while (X != 0 );