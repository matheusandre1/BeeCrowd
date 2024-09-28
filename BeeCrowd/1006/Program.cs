using System.Globalization;

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double pesaA = 2;
double pesoB = 3;
double pesoC = 5;

double media = ((pesaA * a) + (pesoB * b) + (pesoC * c)) / (pesaA + pesoB + pesoC);

Console.WriteLine($"MEDIA = {media.ToString("F1",CultureInfo.InvariantCulture)}");
