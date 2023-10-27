 //variantes

int numerodeasteriscos;
int contador = 0;

//Pedir ao utiliador um numero 
Console.WriteLine("Qual o caracter que deseja?");
string asterisco=Console.ReadLine();

Console.WriteLine("Numero desejado");
numerodeasteriscos = int.Parse(Console.ReadLine());
//Ciclos
while (contador < numerodeasteriscos * 2)
{
    
    Console.Write(asterisco);
    contador += 1;
}


//Resultado

