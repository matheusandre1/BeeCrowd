int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    var dobro = i * i;
    var quadrado = dobro * i;
    Console.WriteLine($"{i} {dobro} {quadrado}");
    Console.WriteLine($"{i} {dobro + 1} {quadrado + 1}");
}