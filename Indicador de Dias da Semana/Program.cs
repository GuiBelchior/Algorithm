//Variaveis
string diadasemana
//Pedir o dia
Console.WriteLine("Qual é o dia?");
diadasemana = Console.ReadLine();
//OU!!!!

switch (diadasemana)
{   case "1":
        diadasemana = "segundafeira";
        break;
    case "2":
        diadasemana = "tercafeira";
        break;
    case "3":
        diadasemana = "quartafeira";
        break;
    case "4":
        diadasemana = "quintafeira";
        break;
    case "5":
        diadasemana = "sextafeira";
        break;
    case "6":
        diadasemana = "sabado";
        break;
    case "7":
        diadasemana = "domingo";
        break;
}
Console.WriteLine($"Escolheu o dia {diadasemana} ");

//Traduzir o numero para o dia


//Apresentar o dia escolhido no final