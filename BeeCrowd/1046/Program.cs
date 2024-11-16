string[] horas = Console.ReadLine().Split(' ');

int horaInicial = int.Parse(horas[0]);
int horaFinal = int.Parse(horas[1]);

if (horaFinal <= horaInicial)
{
    horaFinal += 24;
}

Console.WriteLine($"O JOGO DUROU {horaFinal - horaInicial} HORA(S)");