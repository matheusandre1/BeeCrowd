
int raio = int.Parse(Console.ReadLine());
double pi = 3.14159;
double  volumeEsfera = (4.0/3)  * (pi * Math.Pow(raio,3));

Console.WriteLine($"VOLUME = {volumeEsfera.ToString("F3")}");