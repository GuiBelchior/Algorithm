Console.WriteLine("Indique quantos Alunos tem:");
int numeroTurma = int.Parse(Console.ReadLine());

double notaMaisAlta = 0;
double notaMaisBaixa = 20.0;
double notaMediaRegistada = 0;
double mediaTurma;
int contadorAlunos = 1;
while (contadorAlunos <= numeroTurma)
{
    Console.WriteLine($"Indique a nota do aluno n.º {contadorAlunos}");
    double nota = double.Parse(Console.ReadLine());
    notaMediaRegistada += nota;
    if (contadorAlunos == 1)
    {
        notaMaisAlta = nota;
        notaMaisBaixa = nota;
    }
    if (nota < notaMaisBaixa)
    {
        notaMaisBaixa = nota;
    }
    if (nota > notaMaisAlta)
    {
        notaMaisAlta = nota;
    }
    if (nota < notaMaisBaixa)
    {
        notaMaisBaixa = nota;
    }
    contadorAlunos++;
}
//Apresentação de Resultado
mediaTurma = notaMediaRegistada / numeroTurma;
Console.WriteLine($"A média de nota de Geometria dos Alunos da turma de {numeroTurma} é de {mediaTurma}.");
Console.WriteLine($"A nota mais baixa é de: {notaMaisBaixa}");
Console.WriteLine($"A nota mais alta é de: {notaMaisAlta}");
