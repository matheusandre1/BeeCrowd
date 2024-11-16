string[] numeros = Console.ReadLine().Split(' ');
double num1 = double.Parse(numeros[0]);
double num2 = double.Parse(numeros[1]);
double num3 = double.Parse(numeros[2]);
double num4 = double.Parse(numeros[3]);

double media = ((num1 * 2) + (num2 * 3) + (num3 * 4) + (num4 * 1)) / 10;

media = Math.Floor(media * 10) / 10;
Console.WriteLine($"Media: {media.ToString("F1")}");
if(media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 5)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");
    double notaExame = double.Parse(Console.ReadLine());

    Console.WriteLine($"Nota do exame: {notaExame:F1}");

    media += notaExame;

    media /= 2.0;

    if(media >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
        Console.WriteLine($"Media final: {media:F1}");
    }
    else
    {
        Console.WriteLine("Aluno reprovado");
    }
}