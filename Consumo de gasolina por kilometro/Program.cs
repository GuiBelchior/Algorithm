//Saber o Consumo de Gasolina Por 100 Kilometro e quanto me vai custa.

//variaveis
float kilometros = 100;
double preco;
double GastoPorKm;
double media;
double precoPorLitro;

//Valores 

Console.WriteLine("Quanto custa a sua gasolina?");
preco =double.Parse(Console.ReadLine());
Console.WriteLine("Quanto é que o seu carro gasta por km?");
GastoPorKm = double.Parse(Console.ReadLine());

Console.WriteLine("____________________________________");

// a formula 
media = kilometros / GastoPorKm;
precoPorLitro= (GastoPorKm * preco)*kilometros;

//apresentar o resultado
Console.WriteLine($"O meu carrito gasta em  média: {media} litro aos 100 km");
Console.WriteLine($"Gasto {precoPorLitro} euros para cada 100 km");



