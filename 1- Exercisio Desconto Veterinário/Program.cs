//Instrução de decisão
//(não deve usar instruções de repetição nem estruturas, pode e deve utilizar sub-rotinas se necessário.
//Com o objectivo de promover a vacinação, um veterinário pretende atribuir um desconto nas vacinas para
//gatos mediante o seu comprimento.Crie uma aplicação que solicite os dados de um gato e indique ao utilizador
//qual o desconto a atribuir com base no quadro seguinte.


//Constantes
const double COMPRIMENTOSEIS = 6;
const double COMPRIMENTODEZ=10;
const double COMPRIMENTOQUINZE = 15;
const double COMPRIMENTODEZOITO = 18;
const double COMPRIMENTOVINTECINCO = 25;

//variantes
double comprimentoDado;
double generoDado;

Console.WriteLine("Bemvindo ao detector de descontos do Vet.");

//Pedir o comprimento do bicho
Console.WriteLine("Qual é o comprimento do bicho?");
comprimentoDado=double.Parse(Console.ReadLine());

//pedir o genero do bicho
Console.WriteLine("Qual é o genero do bicho? 1- masculino 2- feminino");
generoDado = double.Parse(Console.ReadLine());
//um filtro para depurar os limites entre comprimento maximo e minimo e o seu genero
if (comprimentoDado >= COMPRIMENTOSEIS && comprimentoDado < COMPRIMENTODEZ) //um filtro para depurar os limites entre 
{
    //depois outro filtro a saber o genero e entregar o valor de desconto.
    if (generoDado == 2)
    {
        Console.WriteLine("O desconto do seu animal é de 10%.");
    }
    else
    {
        Console.WriteLine("O seu bicho tem um desconto de 5%");
    }
}
if (comprimentoDado >= COMPRIMENTODEZ && comprimentoDado < COMPRIMENTOQUINZE)
{
    if (generoDado == 1)
    {
        Console.WriteLine("O desconto do seu animal é de 9%.");
    }
    else
    {
        Console.WriteLine("O seu bicho tem um desconto de 5%");
    }
}
if (comprimentoDado >= COMPRIMENTOQUINZE && comprimentoDado < COMPRIMENTODEZOITO)
{
    if (generoDado == 2)
    {
        Console.WriteLine("O desconto do seu animal é de 8%.");
    }
    else
    {
        Console.WriteLine("O seu bicho tem um desconto de 5%");
    }
}
if (comprimentoDado >= COMPRIMENTODEZOITO && comprimentoDado < COMPRIMENTOVINTECINCO)
{
    Console.WriteLine("O desconto do seu animal é de 7%.");
    if (comprimentoDado > 25 || comprimentoDado < 6)
    {
        Console.WriteLine("O desconto do seu animal é de 5%.");
    }
    else
    {
        Console.WriteLine("O seu bicho tem um desconto de 5%");
    }
}

// este é para os restantes valores, que passado os 4 filtros ainda está cá, então
//verifica-se que é um caso restante.
if (comprimentoDado > COMPRIMENTOVINTECINCO || comprimentoDado < COMPRIMENTOSEIS)
{
    Console.WriteLine("O desconto do seu animal é de 5%.");
}

