
using System.Globalization;

string[] peca1 = Console.ReadLine().Split(' ');

int codigo1 = int.Parse(peca1[0]);
int qtd1 = int.Parse(peca1[1]);
double preco1 = double.Parse(peca1[2]);

string[] peca2 = Console.ReadLine().Split(' ');

int codigo2 = int.Parse(peca2[0]);
int qtd2 = int.Parse(peca2[1]);
double preco2 = double.Parse(peca2[2]);

double somaTotalPeca1 = qtd1 * preco1;
double somaTotalPeca2 = qtd2 * preco2;
double total = somaTotalPeca1 + somaTotalPeca2;
Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");

