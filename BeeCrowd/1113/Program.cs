
int num1 = 0;
int num2 = 0;
do
{
    string[] valores = Console.ReadLine().Split(' ');
     num1 = int.Parse(valores[0]);
     num2 = int.Parse(valores[1]);

    if ( num1 == num2)
    {
        break;
    }
    else if (num1 > num2)
    {
        Console.WriteLine("Decrescente");
    }
    else
    {
        Console.WriteLine("Crescente");
    }
}while (num1 != num2 );
