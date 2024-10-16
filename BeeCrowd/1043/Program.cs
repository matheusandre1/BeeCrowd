
string[] leitura = Console.ReadLine().Split(' ');

double numA = double.Parse(leitura[0]);
double numB = double.Parse(leitura[1]);
double numC = double.Parse(leitura[2]);

double somaBC = numB + numC;
double somaAC = numA + numC;
double somaAB = numA + numB;

double perimetro;
double trapezio;
if (somaBC > numA && somaAC > numB && somaAB > numC)
{
    trapezio = numA + numB + numC;
    Console.WriteLine($"Perimetro = {trapezio.ToString("F1")}");
}
else
{    
    perimetro = ((numB + numA ) * numC) / 2;
    Console.WriteLine($"Area = {perimetro.ToString("F1")}");
}