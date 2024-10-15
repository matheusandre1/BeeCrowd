
string[] numeros = Console.ReadLine().Split(' ');

int numA = int.Parse(numeros[0]);
int numB = int.Parse(numeros[1]);
int numC = int.Parse(numeros[2]);
int numD = int.Parse(numeros[3]);

bool soma = (numC + numD) > numA + numB;
int somaAb =numA + numB;

if ((numB > numC) && (numD > numA) && soma && numC > 0 && numD > 0 && (numA % 2 == 0))
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}
