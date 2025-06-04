decimal salarioFixo, vendas, comissao, salarioFinal;

Console.WriteLine("Digite o salário fixo do funcionário: ");
salarioFixo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor total das vendas: ");
vendas = Convert.ToDecimal(Console.ReadLine());

comissao = vendas * 0.04m;
salarioFinal = salarioFixo + comissao;

Console.WriteLine("Comissão: R$" + comissao);
Console.WriteLine("Salário final: R$" + salarioFinal);