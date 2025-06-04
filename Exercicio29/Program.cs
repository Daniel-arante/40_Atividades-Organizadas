decimal precoOriginal, novoPreco;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite o preço do produto: ");
    precoOriginal = Convert.ToDecimal(Console.ReadLine());

    if (precoOriginal > 0)
    {
        novoPreco = precoOriginal - (precoOriginal * 0.10m);
        Console.WriteLine("O novo preço com 10% de desconto é: R$ " + novoPreco);
    }
    else
    {
        Console.WriteLine("Preço inválido! Digite um valor maior que zero.");
    }

    Console.WriteLine("Deseja calcular outro produto?");
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