
//Constantes


//Variantes

string produto;
//Base de descrição
string descricao1 = ("Una botelha");
string descricao2 = ("Una lata");
string descricao3 = ("Una vasa");
//Pedir o Produto pretendido.

Console.WriteLine("Indique o produto pretendido:");
produto = Console.ReadLine();

//Determinar cada produto para cada descrição

switch (produto)
{
    case "garrafa":
        produto = descricao1;
        break;
    case "lata":
        produto = descricao2;
        break;
    case "copo":
        produto = descricao3;
        break;

    default:
        produto = "";
        break;
}

Console.WriteLine($"O seu produto tem a seguinte descrição: ");


Console.WriteLine($"{produto}");




//Apresentar o resultado
