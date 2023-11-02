//Verificador de notas de ingresso
// Constantes
using System;

const int NOTAMATEMATICA = 14;
const int IDADEDEENTRADA = 17;
const int MEDIAPTMAT = 16;

//Variaveis
string nome = "";
double matematica = 0;
double portugues = 0;
double idade = 0;
double media;
string listaAlunosAdmitidos = "";
string listaAlunosNaoAdmitidos = "";
int contadorAdmitidos = 0;
int contadorNaoAdmetidos = 0;
double contadorAlunos = 1;
double numeroTurma = 0;
//pedir as informações de numero de alunos
Console.WriteLine("Veja aqui as colocações!");
Console.WriteLine("Indique o numero de alunos na turma");
numeroTurma=double.Parse(Console.ReadLine());
//seguir para um ciclo onde consigamos inserir o nome 
while (contadorAlunos <= numeroTurma)
{
    Console.WriteLine("Insira o seu nome:");
    nome= Console.ReadLine();
    Console.WriteLine("Insira a sua nota final de matemática:");
    matematica=double.Parse(Console.ReadLine());
    Console.WriteLine("Insira a sua nota final de portugues");
    portugues= double.Parse(Console.ReadLine());

    media = (matematica + portugues)/ 2;

    if (matematica >= NOTAMATEMATICA || media >= MEDIAPTMAT && idade >= IDADEDEENTRADA)
    { 
    Console.WriteLine($"{nome} pode ser matriculado");
    contadorAdmitidos += 1;
        listaAlunosAdmitidos += $"{nome};";
    }
    else
    {   
    Console.WriteLine($"{nome} não pode ser matriculado, pois a matemática tirou {matematica} e PT {portugues} tem uma media de {media}");
    contadorNaoAdmetidos += 1; 
    listaAlunosNaoAdmitidos +=$"{nome};";
    }
    contadorAlunos++;
}
Console.WriteLine($"Alunos Ingressados: {contadorAdmitidos}");

Console.WriteLine($"Lista de Alunos ingressados: {listaAlunosAdmitidos}");

Console.WriteLine ($"Lista de Alunos não ingressados:{listaAlunosNaoAdmitidos}");
