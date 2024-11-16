int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');

    double num1 = double.Parse(valores[0]);
    double num2 = double.Parse(valores[1]);
    double num3 = double.Parse(valores[2]);

    double media = (num1 * 2) + (num2 * 3) + (num3 * 5);
    double mediaPonde = media / 10;
    Console.WriteLine(mediaPonde.ToString("F1"));
}