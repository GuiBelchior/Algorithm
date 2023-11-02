// See https://aka.ms/new-console-template for more information
Console.WriteLine("_______________Jogo do Adivinha_______________");
//variantes
Random random = new Random();
double modoJogo;
double numeroAdivinha;
double numeroRegistado;
double tentativas = 1;
double contadordeacertou = 0;
string modo = "";
Console.WriteLine("Escolha o modo de jogo: 1) Iniciante 2) Médio 3) Experiente");
modoJogo=double.Parse(Console.ReadLine());

switch (modoJogo)
{
	case 1:
        modo = "Iniciante";
		Console.WriteLine("Escolheu modo Iniciante");
		while(tentativas<=3)
		{
            numeroAdivinha=random.Next(1, 10);
			Console.WriteLine($"Tentativa n.º {tentativas} Adivinhe o numero:");
			numeroRegistado = double.Parse(Console.ReadLine());
			if (numeroRegistado == numeroAdivinha)
			{
				Console.WriteLine($"ACERTOUUU!O numero para adivinhar é o {numeroAdivinha}");
				contadordeacertou++;
			}
			else
			{
                if (numeroRegistado > numeroAdivinha)
                {
                    Console.WriteLine("Mais para baixo!");
                }
                else
                {
                    Console.WriteLine("Mais para cima!");
                }
                Console.WriteLine("Tente Novamente.");
				tentativas++;
				continue;
			}
        }
		break;
		case 2:
        modo = "médio";
        Console.WriteLine("Escolheu modo Médio");
        while (tentativas <= 10)
        {
            numeroAdivinha = random.Next(1, 30);
            Console.WriteLine($"Tentativa n.º {tentativas} Adivinhe o numero:");
            numeroRegistado = double.Parse(Console.ReadLine());
            if (numeroRegistado == numeroAdivinha)
            {
                Console.WriteLine($"ACERTOUUU!O numero para adivinhar é o {numeroAdivinha}");
                contadordeacertou++;
            }
            else
            {
                if (numeroRegistado > numeroAdivinha)
                {
                    Console.WriteLine("Mais para baixo");
                }
                else
                {
                    Console.WriteLine("Mais para cima");
                }
                Console.WriteLine("Tente Novamente.");
                tentativas++;
                continue;
            }
        }
        break;
        case 3:
        modo = "Avançado";
        Console.WriteLine("Escolheu modo Avançado");
        while (tentativas <= 15)
        {
            numeroAdivinha = random.Next(1, 50);
            Console.WriteLine($"Tentativa n.º {tentativas} Adivinhe o numero:");
            numeroRegistado = double.Parse(Console.ReadLine());
            if (numeroRegistado == numeroAdivinha)
            {
                Console.WriteLine($"ACERTOUUU!O numero para adivinhar é o {numeroAdivinha}");
                contadordeacertou++;
            }
            else
            {
                if( numeroRegistado > numeroAdivinha)
                {
                    Console.WriteLine("Mais para baixo");
                }
                else
                {
                    Console.WriteLine("Mais para cima ");
                }

                Console.WriteLine("Tente Novamente.");
                tentativas++;
                continue;
            }
        }
        break;

    default:
        Console.WriteLine("Não foi possivel encontrar o modo de jogo pretendido.Tente Novamente.");
		break;
}
Console.WriteLine($"Em modo {modo} acertou: {contadordeacertou}");