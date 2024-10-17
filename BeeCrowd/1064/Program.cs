
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());
double num4 = double.Parse(Console.ReadLine());
double num5 = double.Parse(Console.ReadLine());
double num6 = double.Parse(Console.ReadLine());

List<double> list = new List<double>();

list.Add(num1);
list.Add(num2);
list.Add(num3);
list.Add(num4);
list.Add(num5);
list.Add(num6);

int contagemNumeroInteiro = 0;
double media = 0;
double soma = 0;

for( int i =0; i < list.Count; i++)
{
    if( list[i] > 0)
    {
        contagemNumeroInteiro++;
        soma = soma + list[i];
    }
    media = soma / contagemNumeroInteiro;
    
}

Console.WriteLine($"{contagemNumeroInteiro} valores positivos");
Console.WriteLine(media.ToString("F1"));