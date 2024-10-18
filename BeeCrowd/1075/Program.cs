
int valorInteiro = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10000; i++)
{
    if ( i % valorInteiro == 2)
    {
        Console.WriteLine(i);
    }
}
