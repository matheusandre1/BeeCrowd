
int casosDeTestes = int.Parse(Console.ReadLine());
int contador = 0;

while ( contador < casosDeTestes )
{
    string[] cabos = Console.ReadLine().Split(' ');
    int raio1 = int.Parse(cabos[0]);
    int raio2 = int.Parse(cabos[1]);

    Console.WriteLine(raio1 + raio2);
    contador++;
}