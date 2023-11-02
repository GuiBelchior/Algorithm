// O organismo público responsável pela meteorologia em Portugal necessita de
// fazer um estudo acerca da temperatura na cidade do Porto.
//Crie uma aplicação capaz de recolher durante n dias a temperatura, e no final,
//informar qual o pico de calor ocorrido, assim como a média das temperaturas
//recolhidas. Em cada dia apenas será efetuada uma única recolha.
//Variantes
using System.Net.Http.Headers;

double contadordias = 0;
double temperatura = 0;
double maxtemperatura = 0;
double condicao = 1;
double registoTemperatura = 0;
double media;
Console.WriteLine("Medidor de temperatura_________");
while (condicao == 1)
{
    //Indicar o dia com um um contador; "Dia 1, qual é a temperatura de hoje?"
    Console.WriteLine($"No dia {contadordias} qual foi a temperatura registada?");
    temperatura = double.Parse(Console.ReadLine());
    registoTemperatura = 0 + temperatura;
    contadordias++;
    if (temperatura > maxtemperatura)
    {
        maxtemperatura += temperatura;
    }
    Console.WriteLine("Deseja Continuar? 1- Sim 2- Não");
    condicao = double.Parse(Console.ReadLine());
    if (condicao == 2)
    {
        condicao--;
        Console.WriteLine("Registo finalizado");
        break;
    }
}
//verificar se essa temperatura é maior que a guardada numa caixa, se sim, metemos enssa caixa;

media = (registoTemperatura) / contadordias;
Console.WriteLine($"A média de temperatura ao longo de {contadordias} dias é de {media}");
Console.WriteLine($"A maior temperatura regista é de {maxtemperatura}.");
//Perguntar por condição
//Depois de inserir as N temperaturas, apresentar resultados com a média de temperaturas entre esses dias e apresentar a temperatura
//mais alta;