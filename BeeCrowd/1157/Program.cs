int n = int.Parse(Console.ReadLine());
List<int> divisores = new List<int>();


for (int i = 1; i <= n; i++)
{
    if ( n % i == 0) 
    {
        divisores.Add(i); 
    }
}

foreach (var i in divisores)
{
    Console.WriteLine(i);
    
}
