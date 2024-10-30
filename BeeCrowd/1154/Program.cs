
List<double> lista = new List<double>();
double media = 0;
double idade;
double soma = 0;
do{
    idade = double.Parse(Console.ReadLine());
    if (idade > 0)
    {
        lista.Add(idade);
    }
    
}while(idade > 0);

foreach (double numeroidade in lista)
{
    soma+= numeroidade;
    

}
media = soma / lista.Count;
Console.WriteLine(media.ToString("F2"));