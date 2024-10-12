
using System.Globalization;

string name = Console.ReadLine();
double salaryFix = double.Parse(Console.ReadLine());
double totalSales = double.Parse(Console.ReadLine());
double comission = 0.15;
double moneycomission = comission * totalSales;

double totalReceivableInTheMonth = salaryFix + moneycomission;

Console.WriteLine($"TOTAL = {totalReceivableInTheMonth.ToString("F2",CultureInfo.InvariantCulture)}");

