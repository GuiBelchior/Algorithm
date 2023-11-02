// Um centro comercial pretende adequar um pouco mais a decoração do seu
//espaço de lazer e de alimentação à faixa etária dos seus visitantes. Para isso, no
//próximo fim-de-semana, irá recolher informação das pessoas que lá entram, com o
//objetivo de determinar:
//• O número total de visitantes femininos e masculinos;
//• O número de visitantes com idade compreendida entre os 10 e 16 anos e os 16 e 24 anos.
//Constantes
const int IDADEDEZ = 10;
const int IDADEDEZASSEIS = 16;
const int IDADEVINTEQUATRO = 24;

//Variantes
double idade;
double sexo;
double contadorFeminino = 0;
double contadorMasculino = 0;
double contadorDezDezasseis = 0;
double contadorDezasseisVinte = 0;
double condicao;

//Primeiro pedir o sexo e a idade e fazer a contagem
do
{
    Console.WriteLine("Indique a sua idade.");
    idade = double.Parse(Console.ReadLine());
    Console.WriteLine("Indique o seu sexo: 1- Masculino 2- Feminino");
    sexo = double.Parse(Console.ReadLine());
    if (sexo == 1)
    {
        contadorMasculino++;
    }
    else 
    {
        contadorFeminino++;
    }
//AGORA SABER A PORRA DA IDADE e contar os intervalos de idades pedidos
if (idade >=IDADEDEZ && idade <= IDADEDEZASSEIS)
    {
        contadorDezDezasseis++;
    }
if (idade >= IDADEDEZASSEIS && idade <= IDADEVINTEQUATRO)
    {
        contadorDezasseisVinte++;
    }
    Console.WriteLine("Deseja mais? 1-Sim 2-Nao");
    condicao = double.Parse(Console.ReadLine());
}
while (condicao == 1);
Console.WriteLine("__________________________________________________");
Console.WriteLine($" O numero de visitantes masculinos:{contadorMasculino} ");
Console.WriteLine($" O numero de visitantes femininos:{contadorFeminino} ");
Console.WriteLine($" O numero de visitantes entre os 10 e 16:{contadorDezDezasseis} ");
Console.WriteLine($" O numero de visitantes entre os 16 e 24:{contadorDezasseisVinte} ");
