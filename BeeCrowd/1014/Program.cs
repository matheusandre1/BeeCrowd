
using System.Globalization;

int distancia = int.Parse(Console.ReadLine());
double combustivelGasto = double.Parse(Console.ReadLine());

double consumoMedio = distancia / combustivelGasto;

Console.WriteLine($"{consumoMedio.ToString("F3",CultureInfo.InvariantCulture)} km/l");