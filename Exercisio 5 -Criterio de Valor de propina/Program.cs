//Crie uma aplicação que apresente o valor da propina de um aluno considerando os seguintes criterios:
//GRAU: Mestre - 5% licenciatura 2% e idade ate 22 0% entre os 22 e 30 anos 10%  mais de trinta 15%.
//Constantes

const double TAXADELICENCIATURA = 0.02;
const double TAXADEMESTRADO = 0.05;
const double TAXAMENOSDE22 = 0;
const double TAXAVINTETRINTA = 0.10;
const double TAXAMAISTRINTA = 0.15;
//Variantes
double valor = 0;
double valor2 = 0;
double propina;
string idade;
string grau;
double valorpagar;


//Pedir o valor da propina
Console.WriteLine("Por favor indique o valor da propina");
propina = double.Parse(Console.ReadLine());

//PEdir qual é o seu tipo de candidatura
Console.WriteLine("Qual é o seu grau academico: 1- licenciatura 2-mestrado?");
grau = Console.ReadLine();

switch (grau)
{
    case "1":
        valor= TAXADELICENCIATURA * propina;
        break;
    case "2":
        valor = TAXADEMESTRADO * propina;
        break;
    default:
         grau = "";
        break;
}
if (valor != 1 && valor != 2)
{
    Console.WriteLine("Não detectamos o seu grau academico.");
    return;
}
//Indicar o valor da taxa de grau academico.
Console.WriteLine($" A sua taxa de grau tem um valor de {valor}");
Console.WriteLine("________________________________________");
//Pedir a idade

Console.WriteLine("Qual é a sua idade 1:Menor de 22? 2-dos 22-30? 3- + de trinta?");
idade = Console.ReadLine();

switch (idade)
{
    case "1":
        valor2 = TAXAMENOSDE22 * propina    ;
    break;
    case "2":
        valor2 = TAXAVINTETRINTA * propina  ;
    break;
    case "3":
        valor2 = TAXAMAISTRINTA * propina   ;
        break;

    default:
        idade = "";
        break;
}
if (valor2 != 1 && valor2 != 2 && valor2 != 3)
    {
    Console.WriteLine("Não foi encontrado a sua idade.");
    return;
}
//indicar o valor da taxa de idade
Console.WriteLine($" A sua taxa de idade tem um valor de {valor2}");
Console.WriteLine("________________________________________");
//CALCULAR O VALOR DA PROPINA mais a taxa mais a idade e taxa de grau academico

valorpagar = propina + valor + valor2;

Console.WriteLine($"O seu {valorpagar}") 

;