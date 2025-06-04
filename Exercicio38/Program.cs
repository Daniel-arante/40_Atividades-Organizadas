int anoNascimento, anoAtual, idadeAnos, idadeMeses, idadeDias, idadeSemanas;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite o ano de nascimento: ");
    anoNascimento = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o ano atual: ");
    anoAtual = Convert.ToInt32(Console.ReadLine());

    if (anoAtual >= anoNascimento)
    {
        idadeAnos = anoAtual - anoNascimento;
        idadeMeses = idadeAnos * 12;
        idadeDias = idadeAnos * 365;
        idadeSemanas = idadeDias / 7;

        Console.WriteLine("Idade em anos: " + idadeAnos.ToString());
        Console.WriteLine("Idade em meses: " + idadeMeses.ToString());
        Console.WriteLine("Idade em dias: " + idadeDias.ToString());
        Console.WriteLine("Idade em semanas: " + idadeSemanas.ToString());
    }
    else
    {
        Console.WriteLine("Ano atual deve ser maior ou igual ao ano de nascimento.");
    }

    Console.WriteLine("Deseja fazer outro cálculo?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Legal, vamos continuar!");
            break;
        case 2:
            Console.WriteLine("Obrigado por usar o programa. Até mais!");
            break;
        default:
            Console.WriteLine("Opção inválida, finalizando aqui.");
            opcao = 2;
            break;
    }
}