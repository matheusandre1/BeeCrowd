using System.Runtime.Intrinsics.X86;

int valorSegundos = int.Parse(Console.ReadLine());

int Horas = valorSegundos / 3600;
int segundosRes = valorSegundos % 3600;
int Segundos = segundosRes % 60;
int Minutos = segundosRes / 60;

Console.WriteLine($"{Horas}:{Minutos}:{Segundos}");
