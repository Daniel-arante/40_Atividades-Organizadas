int opcao, m1, m5, m10, m25, m50, m100;
decimal total;

opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite a quantidade de moedas de 1 centavo: ");
    m1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de moedas de 5 centavos: ");
    m5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de moedas de 10 centavos: ");
    m10 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de moedas de 25 centavos: ");
    m25 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de moedas de 50 centavos: ");
    m50 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de moedas de 1 real: ");
    m100 = Convert.ToInt32(Console.ReadLine());

    if (m1 >= 0 && m5 >= 0 && m10 >= 0 && m25 >= 0 && m50 >= 0 && m100 >= 0)
    {
        total = (m1 * 0.01m) + (m5 * 0.05m) + (m10 * 0.10m) + (m25 * 0.25m) + (m50 * 0.50m) + (m100 * 1.00m);

        Console.WriteLine("Total economizado: R$ " + total);

        opcao = 0;
    }
    else
    {
        Console.WriteLine("Quantidade inválida. Deseja tentar novamente?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Encerrando o programa.");
                break;
            default:
                Console.WriteLine("Opção inválida. Encerrando o programa.");
                opcao = 2;
                break;
        }
    }
}