int latas, garrafas600, garrafas2L, opcao;
decimal totalLitros;

opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite a quantidade de latas de 350 ml: ");
    latas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de garrafas de 600 ml: ");
    garrafas600 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de garrafas de 2 litros: ");
    garrafas2L = Convert.ToInt32(Console.ReadLine());

    if (latas >= 0 && garrafas600 >= 0 && garrafas2L >= 0)
    {
        totalLitros = (latas * 0.35m) + (garrafas600 * 0.6m) + (garrafas2L * 2.0m);

        Console.WriteLine("Total de litros comprados: " + totalLitros + " L");

        opcao = 0;
    }
    else
    {
        Console.WriteLine("Quantidade inválida. Deseja tentar novamente? ");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                break;
            default:
                Console.WriteLine("Opção inválida. Encerrando o programa.");
                opcao = 2;
                break;
        }
    }
}