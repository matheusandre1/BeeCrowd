 var numerosLidos = int.Parse(Console.ReadLine());
 List<int> numeros = new List<int>();
int contagem = numerosLidos;  
int input = 0;
 while (contagem == numerosLidos){
    input = int.Parse(Console.ReadLine());
    numeros.add(input);    
 }

 if (input < 0 && input % 2 != 0)
    {
        System.Console.WriteLine("ODD NEGATIVE");
    }  
    else if( input > 0 && input % 2 != 0){
        System.Console.WriteLine("ODD POSITIVE");
    }  
    else if (input == 0)
    {
        System.Console.WriteLine("NULL");
    }
    else if( input < 0 && input % 2 == 0 ){
        System.Console.WriteLine("EVEN NEGATIVE");
    }    