//Crie uma aplicação que apresente o valor da propina de um aluno considerando os seguintes criterios:
//GRAU: Mestre - 5% licenciatura 2% e idade ate 22 0% entre os 22 e 30 anos 10%  mais de trinta 15%.
//Constantes
using System.ComponentModel.Design;

const float TAXADELICENCIATURA = 2;
const float TAXADEMESTRADO = 5;
const float TAXAMENOSDE22 = 0;
const float TAXAVINTETRINTA = 10;
const float TAXAMAISTRINTA = 15;
//Variantes
float valor;
float valor2;
int propina;
float idade;
float taxalicenciatura;
float taxademestrado;
float taxamenosvinte;
float taxavintetrinta;
float taxamais30;
string grau;


//Pedir o valor da propina
Console.WriteLine("Por favor indique o valor da propina");
propina = int.Parse(Console.ReadLine());

//PEdir qual é o seu tipo de candidatura
Console.WriteLine("Qual é o seu grau academico: 1- licenciatura 2-mestrado?");
grau = Console.ReadLine();

switch (grau)
{
    case "1":
        taxalicenciatura = TAXADELICENCIATURA;
        break;
    case "2":
       taxademestrado = TAXADEMESTRADO;
        break;
}

if (grau == "!")

    valor2 = (2 / 100) * propina;

else
    valor2 = (5 / 100) * propina;

//Pedir a idade

Console.WriteLine("Qual é a sua idade 1:Menor de 22? 2-dos 22-30? 3- + de trinta?");
idade=float.Parse(Console.ReadLine());

switch (idade)
{
    case 1:
        taxamenosvinte = TAXAMENOSDE22;
        break;
    case 2:
        taxavintetrinta = TAXAVINTETRINTA;
        break;
    case 3:
        taxamais30 = TAXAMAISTRINTA;
        break;
}
if (idade == 1) ;

valor = propina * (5 / propina);

if (idade == 2) ;
    valor = propina * (1 + (10 / 100));

if (idade == 3) ;
valor = propina * (1 + (15 / 100));

//CALCULAR O VALOR DA PROPINA!
float paga= valor+valor2;

Console.WriteLine($"O valor da sua propina é de{paga}");