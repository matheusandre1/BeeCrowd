string[] valores = Console.ReadLine().Split(' ');

double numx = double.Parse(valores[0]);
double numy = double.Parse(valores[1]);

if(numx == numy )
{
    Console.WriteLine("Origem");
}
else if(numx > 0 && numy > 0)
{
    Console.WriteLine("Q1");
}
else if(numx < 0 && numy > 0)
{
    Console.WriteLine("Q2");
}
else if(numx < 0 && numy < 0)
{
    Console.WriteLine("Q3");
}
else if( numx > 0 && numy < 0)
{
    Console.WriteLine("Q4");
}
