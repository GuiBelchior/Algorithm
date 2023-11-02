//Devido à crise o governo decidiu criar uma sobretaxa de irs extraordinaria de 3.5% sobre
//os salarios cujo o valor sseja superior ao salario minimo nacional. Esta
//taxa apenas deve incidir sobre o valor remanescce depois de substraido o salario minimo ao salario do funcionário
//sugira um algoritmo para resolver o problema, acautelando a excepcao prevista para os funcionarios que apenas aufiram o salario minimo nacional
Console.WriteLine("Hello, World!");
//Variantes
double ordenado = 0;
double ordenadominimo = 650;
double taxaIrs = 3.5;
double taxaExtraordinaria = 0;
double valor = 0;
//pedir o ordenado
Console.WriteLine("Indique o seu ordenado");
ordenado =double.Parse( Console.ReadLine());
//se for mais alto que o ordenado minimo entao 3.5 / (ordenado-ordenadominim)
if (ordenado > ordenadominimo)
{
    taxaExtraordinaria =(ordenado - ordenadominimo);
    valor = taxaIrs*(taxaExtraordinaria/100);
    Console.WriteLine($"O seu ordenado tem sobretaxa no valor de  {valor}.");
}
else
{
    Console.WriteLine("O seu ordenado não tem sobretaxa.");
}
//se for menor ou igual a ordenado minimo entao nao fazer nada

//Apresentar
