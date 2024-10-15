
string[] valores = Console.ReadLine().Split(' ');
int num1 = int.Parse(valores[0]);
int num2 = int.Parse(valores[1]);
int num3 = int.Parse(valores[2]);
int[] numeros = new int[3];

numeros [0] = num1;
numeros [1] = num2;
numeros [2] = num3;

List<int> ints = new List<int>();
ints.Add(numeros[0]);
ints.Add(numeros[1]);
ints.Add(numeros[2]);


Array.Sort(numeros);
foreach (int num in numeros)
{
    Console.WriteLine(num);
}
Console.WriteLine();

foreach (int num in ints)
{
    Console.WriteLine(num);
}



