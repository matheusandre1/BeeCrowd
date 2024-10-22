
using System.Collections.Generic;
using System.Linq;
string[] valores = Console.ReadLine().Split(' ');


double A = double.Parse(valores[0]);
double B = double.Parse(valores[1]);
double C = double.Parse(valores[2]);

List<double> descrente = new List<double>();

descrente.Add(A);
descrente.Add(B);
descrente.Add(C);

descrente = descrente.OrderByDescending(x => x).ToList();




double SomaBc = descrente[1] + descrente[2];
double SomaBcQuadrado = (descrente[1] * descrente[1]) + (descrente[2] * descrente[2]);
double aQuadrado = descrente[0] * descrente[0];

if (descrente[0] >= SomaBc)
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else if ( aQuadrado == SomaBcQuadrado)
{
    Console.WriteLine("TRIANGULO RETANGULO");
}
else if ( aQuadrado > SomaBcQuadrado)
{
    Console.WriteLine("TRIANGULO OBTUSANGULO");
}
else if ( aQuadrado < SomaBcQuadrado)
{
    Console.WriteLine("TRIANGULO ACUTANGULO");
}

// Triangulo Equilatero
if (descrente[0] == descrente[1] && descrente[0] == descrente[2] && descrente[1] == descrente[2])
{
    Console.WriteLine("TRIANGULO EQUILATERO");
}
else if (descrente[0] == descrente[1] || descrente[1] == descrente[2] || descrente[0] == descrente[2])
{
    Console.WriteLine("TRIANGULO ISOSCELES");
}