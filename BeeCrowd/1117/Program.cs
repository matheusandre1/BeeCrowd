
int notaValida = 0;

double nota = 0;

double soma = 0;
double media = 0;

while ( notaValida < 2)
{
    nota = double.Parse(Console.ReadLine());

    if ( nota >= 0 && nota <= 10)
    {
        soma += nota;
        notaValida++; 
    }
    else
    {
        Console.WriteLine("nota invalida");
    }  
}
media = soma / 2;
Console.WriteLine($"media = {media}");
