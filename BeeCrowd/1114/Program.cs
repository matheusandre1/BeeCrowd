
int senha = 2002;

int tentativa = 0;
while ( tentativa != senha )
{
    tentativa = int.Parse(Console.ReadLine());

    if ( tentativa == senha)
    {
        Console.WriteLine("Acesso Permitido");
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }
}