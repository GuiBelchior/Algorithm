//Constantes

//Variantes
double numeroTurma;
double mediaTurma = 0;
double nota;
double notaMediaRegistada = 0;
double notaMaxima = 0;
double notaMinima = 0;
double contadorAlunos = 1;

//pedir nº de turma
Console.WriteLine("Indique quantos Alunos tem:");
numeroTurma=double.Parse(Console.ReadLine());
//condicao de contador de alunos em relação ao inserido.
while (contadorAlunos <= numeroTurma)
{ 
    Console.WriteLine($"Indique a nota do aluno n.º {contadorAlunos}");
    nota=double.Parse(Console.ReadLine());
    notaMediaRegistada += nota;
    //registar nota do primeiro aluno hehe
    if (contadorAlunos == 1)
    {
        notaMaxima = nota;
        notaMinima = nota;
    }
    //registar nota mais alta
    if (nota > notaMaxima)
    {
        notaMaxima = 0;
        notaMaxima = nota;
    }
    //registar nota mais baixa
    if (nota < notaMinima && nota > 0)
    {
        notaMinima += nota;
    }
    contadorAlunos++;
}
mediaTurma = notaMediaRegistada / numeroTurma;
//Apresentar Resultados
Console.WriteLine($"média de nota de Geometria dos Alunos da turma de {numeroTurma} é de {mediaTurma}.");
Console.WriteLine($"A nota mais baixa é de: {notaMinima}");
Console.WriteLine($"A nota mais alta é de : {notaMaxima}");