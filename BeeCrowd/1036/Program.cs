string[] valores = Console.ReadLine().Split(' ');
double a = double.Parse(valores[0]);
double b = double.Parse(valores[1]);
double c = double.Parse(valores[2]);

double v = (b * b) - 4 * (a * c);

if (v < 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double X1 = (-b + Math.Sqrt(v)) / (2 * a);
    double X2 = (-b - Math.Sqrt(v)) / (2 * a);
    Console.WriteLine($"R1 = {X1.ToString("F5")}");
    Console.WriteLine($"R2 = {X2.ToString("F5")}");
}