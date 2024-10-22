
int numero = 0;
string entrada;

while ( (entrada = Console.ReadLine()) != null)
{
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        Console.WriteLine("vai ter copa!");
    }
    else
    {
        Console.WriteLine("vai ter duas!");
    }
}
