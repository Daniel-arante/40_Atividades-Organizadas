decimal diagonalMaior, diagonalMenor, area;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite a diagonal maior do losango:");
    diagonalMaior = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite a diagonal menor do losango:");
    diagonalMenor = Convert.ToDecimal(Console.ReadLine());

    if (diagonalMaior > 0 && diagonalMenor > 0)
    {
        area = (diagonalMaior * diagonalMenor) / 2;
        Console.WriteLine("A área do losango é: " + area.ToString("F2") + " unidades²");
    }
    else
    {
        Console.WriteLine("Valores inválidos. As diagonais devem ser maiores que zero.");
    }

    Console.WriteLine("Deseja calcular novamente?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            break;
        case 2:
            Console.WriteLine("Programa encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida. Encerrando o programa.");
            opcao = 2;
            break;
    }
}