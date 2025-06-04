decimal totalConta, valorDividido, felipe;
int carlos, andre, repetir;

repetir = 1;

while (repetir == 1)
{
    Console.WriteLine("Digite o valor total da conta: R$ ");
    totalConta = Convert.ToDecimal(Console.ReadLine());

    if (totalConta > 0)
    {
        valorDividido = totalConta / 3;
        carlos = (int)valorDividido;
        andre = (int)valorDividido;
        felipe = totalConta - (carlos + andre);

        Console.WriteLine("Carlos: R$ " + carlos);
        Console.WriteLine("André: R$ " + andre);
        Console.WriteLine("Felipe: R$ " + felipe);

        repetir = 0;
    }
    else
    {
        Console.WriteLine("Valor inválido. Deseja tentar novamente? (1 para sim, 0 para não): ");
        repetir = Convert.ToInt32(Console.ReadLine());
    }
}