using Flexbus_exercisio;
using System;
UserInteraction ui = new UserInteraction();

//Crie uma solução em C# chamada FlexBus e define uma classe chamada Bus (autocarro) 
//considerando os requisitos a seguir indicados. A classe deve:
//• Expor a propriedade readonly Id que devolve o número inteiro incrementado durante 
//a construção de cada objeto tendo por base o contador lastId.
//• Expor a propriedade readonly NextId que indica qual o próximo Id que será atribuído 
//(i.e., quando for criado um objeto).
//• Impor a indicação da licensePlate e make (enumerador) durante a construção de 
//cada objeto.
//• Expor a propriedade read&write LicensePlate.
//• Expor o método GetWeight() que devolve 5 caso a marca (make) seja Mercedes e 6 
//caso seja qualquer outra marca.
//5) Crie uma pequena aplicação cliente que imprima na consola a seguinte informação após 
//instanciar 1 objeto do tipo Bus:
//• O NextId que será atribuído ao próximo objeto deste tipo que seja criado.
//• A LicensePlate do Bus criado.
//• O peso obtido através da invocação do método GetWeight() do objeto instanciado.

//variations
double makerOption = 0;
Bus bus1 = new Bus();

//Inserir a Matricula
bus1.LicensePlate = ui.AskForString("Please insert the license plate:");

//Pedir o Maker, onde conseguimos correlacionar atraves de um switch se não for mercedez o seu pesoi será 6 T
makerOption = ui.AskForDouble("Whats the Maker of your Bus: 1- Mercedez 2- Other");

//Aproveitar a relação entre o Maker e o Peso do bus numa só questão
switch (makerOption)
{
	case 1:
        bus1.Maker = Maker.Mercedez.ToString();
        bus1.Weight = 5;
        break;
    case 2:
        bus1.Maker = Maker.Outros.ToString();
        bus1.Weight = 6;
        break;
    default:
        Console.WriteLine("Maker not found");
        break;
}

//Indicar as informações do autocarro.
Console.WriteLine("The info about your Bus:");
Console.WriteLine(bus1.InfoBus(bus1));
Console.WriteLine("____________________");

//Esta parte resulta do 5. Exercisio onde é necessário usar um metodo para entregar a LicensePlate, Peso do Bus e indicar o Id do próximo bus a ser registado
Console.WriteLine("Your Bus weight:");
Console.WriteLine(bus1.GetWeight(bus1));
Console.WriteLine("Your Bus Id is:");
Console.WriteLine(Bus.GetLastId(bus1));
Console.WriteLine("The next bus Id will be:");
Console.WriteLine(Bus.GetNextId(bus1)); 

