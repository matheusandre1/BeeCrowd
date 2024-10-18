
int quantidadeLidos = int.Parse(Console.ReadLine());

int tentativas = 0;

while( tentativas != quantidadeLidos)
{
    string[] valores = Console.ReadLine().Split(' ');

    double num1 = double.Parse(valores[0]);
    double num2 = double.Parse(valores[1]);    

    if ( num2 == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else if ( num2 < 0)
    {
        double divisao = (double)num1 / (double)num2;
        Console.WriteLine($"{divisao.ToString("0.0")}");
    }
    else
    {
        double divisao = (double)num1 / (double)num2;
        Console.WriteLine(divisao.ToString("0.0"));
    }

   tentativas++;
}