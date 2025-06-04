decimal salarioMinimo, salarioFuncionario, quantidade;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite o valor do salário mínimo:");
    salarioMinimo = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o salário do funcionário:");
    salarioFuncionario = Convert.ToDecimal(Console.ReadLine());

    if (salarioMinimo > 0)
    {
        quantidade = salarioFuncionario / salarioMinimo;
        Console.WriteLine("O funcionário ganha " + quantidade.ToString("F2") + " salários mínimos.");
    }
    else
    {
        Console.WriteLine("Valor do salário mínimo inválido.");
    }

    Console.WriteLine("Deseja calcular novamente?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Beleza! Vamos continuar...");
            break;
        case 2:
            Console.WriteLine("Tudo bem, até a próxima!");
            break;
        default:
            Console.WriteLine("Ops! Opção inválida. Vamos encerrar por aqui.");
            opcao = 2;
            break;
    }
}