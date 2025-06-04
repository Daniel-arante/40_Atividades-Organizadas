decimal salarioInicial, salarioComAumento, salarioFinal;
string entrada;

Console.WriteLine("Digite o salário do funcionário: ");
entrada = Console.ReadLine();
salarioInicial = Convert.ToDecimal(entrada);

salarioComAumento = salarioInicial + (salarioInicial * 0.15m);
salarioFinal = salarioComAumento - (salarioComAumento * 0.08m);

Console.WriteLine("Salário inicial: " + salarioInicial);
Console.WriteLine("Salário com aumento: " + salarioComAumento);
Console.WriteLine("Salário final após desconto: " + salarioFinal);