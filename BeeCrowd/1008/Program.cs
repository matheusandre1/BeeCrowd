
int number = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
double Value_hours = double.Parse(Console.ReadLine());
double salaryCalculation = hours * Value_hours;

Console.WriteLine($"Number = {number}");
Console.WriteLine($"SALARY = U$ {salaryCalculation.ToString("F2")}");