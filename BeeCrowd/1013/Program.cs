
string[] numeros = Console.ReadLine().Split(' ');
int num1 = int.Parse(numeros[0]);
int num2 = int.Parse(numeros[1]);
int num3 = int.Parse(numeros[2]);

int formula = (num1 + num2 + Math.Abs(num1 - num2)) / 2;

var maior = (formula  + num3 + Math.Abs(formula - num3)) / 2;

Console.WriteLine($"{maior} eh o maior");
