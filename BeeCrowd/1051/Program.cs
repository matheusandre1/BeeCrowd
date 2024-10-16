
double salario = double.Parse(Console.ReadLine());

double imposto;
if (salario >= 0.00 && salario <= 2000.00)
{
    Console.WriteLine("Isento");
}
else if(salario >= 2000.01 && salario <= 3000.00)
{
    imposto = (salario - 2000.00) * 0.08;
    Console.WriteLine($"R$ {imposto.ToString("F2")}");
}
else if(salario >= 3000.01 && salario <= 4500.00)
{
    imposto = (salario - 3000.00)* 0.18 + (1000.00 * 0.08);
    Console.WriteLine($"R$ {imposto.ToString("F2")}");
}
else if ( salario > 4500.00)
{
    imposto = (salario  - 4500.00) * 0.28 + (1500.00 * 0.18) + (1000.00 * 0.08);
    Console.WriteLine($"R$ {imposto.ToString("F2")}");
}