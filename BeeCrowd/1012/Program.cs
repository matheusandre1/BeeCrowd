
using System.Globalization;

string[] medidas = Console.ReadLine().Split(' ');
double pi = 3.14159;
double A = double.Parse(medidas[0]);
double B = double.Parse(medidas[1]);
double C = double.Parse(medidas[2]);

double trianguloRetangulo = (A * C) / 2;
double areaCirculoRaio = pi * Math.Pow(C, 2);
double areaTrapezio = ((A + B)  * C) / 2;
double areaQuadrado = B * B;
double areaTriangulo = A * B;

Console.WriteLine($"TRIANGULO: {trianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture)}");
Console.WriteLine($"CIRCULO: {areaCirculoRaio.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"RETANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
