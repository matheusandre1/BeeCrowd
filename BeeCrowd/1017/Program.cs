
using System.Globalization;

int automovel = 12;
double tempoGastoViagem = double.Parse(Console.ReadLine());
double velocidadeMedia = double.Parse(Console.ReadLine());

double distancia = tempoGastoViagem * velocidadeMedia;

double result = distancia / automovel;

Console.WriteLine(result.ToString("F3"));


