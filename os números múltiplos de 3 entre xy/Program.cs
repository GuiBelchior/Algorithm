//Escreva na consola todos os números múltiplos de 3 entre [x;y];
//CONSTANTES
const int DIVISOR = 3;

//Variaveis
int auxiliar;
int segundoNumero;
int inicialNumero;
string multiplos = "";
string naoMultiplos = "";

//Perguntar pelo primeiro numero
Console.WriteLine("Qual é o seu primeiro numero?");
inicialNumero = int.Parse(Console.ReadLine());
// Perguntar pelo segundo numero
Console.WriteLine("Qual é o seu segundo numero?");
segundoNumero = int.Parse(Console.ReadLine());

//trocar os valores se necessario
if (inicialNumero > segundoNumero)
{
    auxiliar = inicialNumero;
    inicialNumero = segundoNumero;
    segundoNumero= auxiliar;    
}

// Confirmar as escolhas
Console.WriteLine($"Multiplos de {DIVISOR} de {inicialNumero} e {segundoNumero}");

//Encontrar os multiplos de 3 entre os dois numeros
while (inicialNumero <= segundoNumero) //Aqui o while vai ter uma formula if dentro do seu ciclo, cada vez que passa por um numero verifica se é multiplo 
{
    if (inicialNumero % DIVISOR == 0)
    {
        multiplos += inicialNumero;
        multiplos += ";";
    }
    else
    {
        naoMultiplos += inicialNumero;
        naoMultiplos += ";";
    }
    inicialNumero++;
}

//Resultado
if (multiplos != "")
{
    Console.WriteLine($"Os multiplos de {DIVISOR} são:{multiplos}");
}
else 
{
    Console.WriteLine("Não existem multiplos.");
}

if (naoMultiplos != "")
{
    Console.WriteLine($"Os nao multiplos de {DIVISOR} são:{naoMultiplos}");
}
else
{
    Console.WriteLine("Nao existem nao multiplos.");
}