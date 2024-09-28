
using System.Globalization;

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

double pesaA =  3.5;
double pesoB =  7.5;
double media = ((pesaA * a) + (pesoB * b)) / (pesaA + pesoB);

Console.WriteLine($"MEDIA = {media.ToString("F5")}");
