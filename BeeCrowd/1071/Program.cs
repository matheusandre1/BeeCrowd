using System.Collections.Generic;
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int soma = 0;


List<int> list = new List<int>();

if (num1 == num2) {
    Console.WriteLine(0);
} 
else {
    if(num1 > num2)
{
        for (int i = num1; i > num2; i--)
        {
            list.Add(i);
        }
    }

    list.Remove(list[0]);

    foreach (var item in list)
    {
        if (item % 2 != 0)
        {
            soma += item;
        }
    }

    Console.WriteLine(soma);
}




