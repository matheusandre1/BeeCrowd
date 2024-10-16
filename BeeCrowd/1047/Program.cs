
string[] jogo = Console.ReadLine().Split(' ');

int horaInicial = int.Parse(jogo[0]);
int minutoInicial = int.Parse(jogo[1]);

int horaFinal = int.Parse(jogo[2]);
int minutoFinal = int.Parse(jogo[3]);

int duracaoHora = horaInicial - horaFinal;
int duracaoMinuto = minutoInicial - minutoFinal;

DateTime viraHora = new DateTime(duracaoMinuto);

Console.WriteLine($"O JOGO DUROU {viraHora.Hour * 24} HORA(S) E {duracaoMinuto * 60} MINUTO(S)");