
int valor = int.Parse(Console.ReadLine());
int aux;
Console.WriteLine($"{valor/365} ano(s)");
aux = valor % 365;
Console.WriteLine($"{aux/30} mes(es)");
aux= aux % 30;
Console.WriteLine($"{aux/1} dia(s)");