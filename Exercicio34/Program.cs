decimal lado, area;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite o valor do lado do quadrado:");
    lado = Convert.ToDecimal(Console.ReadLine());

    if (lado > 0)
    {
        area = lado * lado;
        Console.WriteLine("A área do quadrado é: " + area.ToString("F2") + " m²");
    }
    else
    {
        Console.WriteLine("Valor inválido. O lado deve ser maior que zero.");
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