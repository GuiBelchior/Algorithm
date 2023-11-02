using System.Net.Http.Headers;

Console.WriteLine("Bemvindo ao Rating de Hospital");
Console.WriteLine("_______________________________");
//Constantes
const  double SESSENTA = 60;
const double HORAMINIMA = 2;
//variantes
double condicao = 1;
double genero;
double idade;
double hora;
double valorServico;
double contadorMasculino = 0;
double contadorfeminino = 0;
double contadorSessentaMasculino= 0;
double contadorSessentaFeminino = 0;
double mulheresMaisDuasHoras = 0;
double homensMaisDuasHoras = 0;
double registoHoras = 0;
double inquiridosMais2Horas = 0;
double contadorSessentaMasculinoGostou = 0;
double contadorfemnaogostou = 0;
double mediaHoraFeminino = 0;
double percentagemFemininaNaoGostou = 0;

//O loop onde vai registar todas as 4 coisas em cada uma delas registar os dados pedidos de modo
// a registar os objectivos da consola.
while (condicao == 1)
    {
    //registo de género
    Console.WriteLine("Indique o seu genero: 1- Masculino 2- feminino");
    genero=double.Parse(Console.ReadLine());
    if(genero==1)
    {
        contadorMasculino++;
    }
    else 
    { 
        contadorfeminino++; 
    }

    //registo de idade
    Console.WriteLine("Indique a sua idade:");
    idade=double.Parse(Console.ReadLine());
    if (idade >= SESSENTA && genero == 1)
    {
        contadorSessentaMasculino++;
    }
    else if (idade >= SESSENTA && genero == 2);
    {
        contadorSessentaFeminino++;
    }

    //registo de tempo de espera
    Console.WriteLine("Indique quanto tempo teve a espera:");
    hora = double.Parse(Console.ReadLine());
    registoHoras += hora;
    if (hora >= HORAMINIMA) 
    {
        Console.WriteLine("Este paciente passou das 2 horas");
        if (genero == 2)
        {
            mulheresMaisDuasHoras++;
            mediaHoraFeminino = registoHoras / contadorfeminino;
        }
        else
        {
            homensMaisDuasHoras++;
        }

        //Faço a soma dos inquiridos que tiveram mais de duas horas a espera
        inquiridosMais2Horas += homensMaisDuasHoras + mulheresMaisDuasHoras;
    }

    //Registo de atendimento
    Console.WriteLine("Gostou do seu atendimento? 1-Sim 2-Nao");
    valorServico = double.Parse(Console.ReadLine());
    if (genero == 1 && idade > SESSENTA && valorServico == 1)
    {
        contadorSessentaMasculinoGostou++;
    }
    if (genero == 2 && valorServico == 2)
    {
        contadorfemnaogostou++;
    //Aqui adicionei o calculo para saber a percentagem feminina que não gostou
        percentagemFemininaNaoGostou += contadorfemnaogostou / (contadorMasculino + contadorfeminino)*100;
    }
    Console.WriteLine("Deseja Finalizar a inserção? 1- Não 2- Sim");
    condicao = double.Parse(Console.ReadLine());
}

//Um registo de todos os dados pedidos 
Console.WriteLine($"O numero de inquiridos que esperaram mais de 2 horas :{inquiridosMais2Horas}");
Console.WriteLine($"Percentagem de pacientes feminino que nao gostaram do servico:{percentagemFemininaNaoGostou}%");
Console.WriteLine($"O numero de pacientes do genero masculino maiores de 60: {contadorSessentaMasculinoGostou}");
Console.WriteLine($"Média do tempo de espera dos pacientes femininos que não gostaram do atendimento : {mediaHoraFeminino}");

