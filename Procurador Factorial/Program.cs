//Há a necessidade de criar uma aplicação que, perante a introdução de dois
//limites inteiros, calcule a quantidade e o somatório de todos os valores ímpares
//nesse intervalo. Note que os limites do intervalo podem ser inseridos no menor para
//o maior ou do maior para o menor.
//• Desenhe e implemente um algoritmo que resolva o problema usando cada um
//dos ciclos que aprendeu..

//variantes
double primeiroNumero;
double ultimoNumero;
double numeroAuxiliar;
double contadorNumeros = 0;
string listaPar = "";
string listaImpar = "";
double contadorNumerosPares = 0;
double contadorNumerosImpares= 0;
//Pedir os intervalo de numeros
Console.WriteLine("Indique o primeiro numero");
primeiroNumero=double.Parse(Console.ReadLine());

Console.WriteLine("Indique o segundo numero");
ultimoNumero= double.Parse(Console.ReadLine());

// Aplicar Teoria dos Canecos em caso de erro do utilizador
if (primeiroNumero > ultimoNumero)
{
    numeroAuxiliar = primeiroNumero;
    primeiroNumero = ultimoNumero;
    ultimoNumero = numeroAuxiliar;
}
contadorNumeros = 0 + primeiroNumero;

//procura pelos numeros os numeros pares e impares
while (contadorNumeros <= ultimoNumero)
{
    if (contadorNumeros % 2 == 0)
    {
        listaPar += $"{contadorNumeros}";
        listaPar += ";";
        Console.WriteLine("este numero é par");
        contadorNumerosPares++;
    }
    else
    {
        listaImpar += $"{contadorNumeros}";
        listaImpar += ";";
        Console.WriteLine("este numero é impar");
        contadorNumerosImpares++;
    }
    contadorNumeros++;
}
//Implementar um resultado que diga Numero de impares entre X e Y, que são os : xxxxxxx;
Console.WriteLine($"De os numeros {primeiroNumero} e {ultimoNumero} foi identificados: {contadorNumerosPares} numeros pares sendo eles {listaPar}");
Console.WriteLine($"De os numeros {primeiroNumero} e {ultimoNumero} foi identificados: {contadorNumerosImpares} numeros pares sendo eles {listaImpar}");



