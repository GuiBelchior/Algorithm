//Desenvolva um programa que receba um numero indefinido de idades e que mostre na consola a
//quantidade de pessoas que 65 < idade <80. (entre os 65 e 80 anos).
using System.ComponentModel;

//constantes
const int SESSENTACINTO = 65;
const int OITENTA = 80;

//Variaveis
int idade;
int condicao = 2;
int contadorsessentaoitenta = 0;

//Perguntar idade ao utilizador
Console.WriteLine("______Bemvindo ao registador de idades______");
while (condicao == 2)
{
    //Inserir as idades
    Console.WriteLine("Qual é a sua idade? Para finalizar insira 1.");
    idade = int.Parse(Console.ReadLine());
    if (idade >= SESSENTACINTO && idade <= OITENTA)
    {
        //registar as idades entre 65 e 80 anos.
        contadorsessentaoitenta++;
    }
    if (idade == 1)
    {
        condicao--;
    }
}

//Apresentar a quantidade de pesaos entre os 65 e 80 anos
Console.WriteLine($"O numero de pessoas entre os 65 e 80 anos foram: {contadorsessentaoitenta}");
