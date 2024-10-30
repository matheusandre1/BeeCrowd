int valor = int.Parse(Console.ReadLine());

int[] vetor = new int[10];

for (int i = 1; i < vetor.Length; i++)
{
    Console.WriteLine($"N[{i}] = {vetor[0] = valor * 2}");
}