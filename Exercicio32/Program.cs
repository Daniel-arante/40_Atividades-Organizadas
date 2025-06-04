decimal pesoKg, pesoGramas;
int opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite o peso em quilos: ");
    pesoKg = Convert.ToDecimal(Console.ReadLine());

    if (pesoKg > 0)
    {
        pesoGramas = pesoKg * 1000;
        Console.WriteLine("O peso em gramas é: " + pesoGramas.ToString("F0") + " g");
    }
    else
    {
        Console.WriteLine("Peso inválido. Digite um valor maior que zero.");
    }

    Console.WriteLine("Deseja converter outro peso?");
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


//O .ToString("F0") serve para converter o número para texto com 0 casas decimais.