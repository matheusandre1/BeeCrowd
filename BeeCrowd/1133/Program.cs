int num1 = Convert.ToInt32(Console.ReadLine());
int num2  = Convert.ToInt32(Console.ReadLine());

int maior = Math.Max(num1, num2);
int menor = Math.Min(num1, num2);

for (int i = menor; i < maior; i++)
{
    if ( i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}