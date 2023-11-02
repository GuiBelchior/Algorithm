//Variantes
string matricula;
double cor;
string matriculas = "";
double condicao = 1;
double contadorCarros = 1;
double contadorCarrosAmarelos = 0;
double contadorCarrosAzuis = 0;
//Contagem

while (condicao == 1)
{
    Console.WriteLine("Insira a matricula:");
    matricula = Console.ReadLine();

    matriculas +=$"{matricula};";

    Console.WriteLine("Insira a cor: 1-Amarelo 2-Azul.");
    cor = int.Parse(Console.ReadLine());
    contadorCarros++;
    // Apresentar contagem
    if(cor != 1 && cor != 2)
    {
        Console.WriteLine("Cor inserida invalida.");
        continue;
    }
    if (cor == 1)
    {
        contadorCarrosAmarelos++; 
    }
    else
    {
        contadorCarrosAzuis++;
    }
    Console.WriteLine("Deseja continuar? 1-Sim 2-Nao.");
    condicao=double.Parse(Console.ReadLine());
    if(condicao != 1 && condicao != 2)
    {
        Console.WriteLine("Opcao invalida.");
    }
}
Console.WriteLine($"Numero de carros Amarelos:{contadorCarrosAmarelos}");
Console.WriteLine($"Numero de carros Azuis:{contadorCarrosAzuis}");
Console.WriteLine($"Matriculas registadas : {matriculas}");