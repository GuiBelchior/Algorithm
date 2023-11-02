//Escreve um switch que receba uma letra e determine se é uma vogal ou uma consoante.


//Variantes

using System.ComponentModel.Design;

string opcao;
//Pedir a letra pretendida.

Console.WriteLine("Indique a letra pretendida:");
opcao =Console.ReadLine();

//Identificar se é vogal ou consoante

switch (opcao)
{
	case "A":
		opcao = "vogal";
		break;
	case "E":
		opcao = "vogal";
		break;
	case "I":
		opcao = "vogal";
		break;
	case "O":
		opcao = "vogal";
		break;
	case "U":
		opcao = "vogal";
		break;

	default:
		opcao = "consoante";
		break;
}
//Apresentar o resultado
Console.WriteLine($"A sua palavra é uma {opcao}");