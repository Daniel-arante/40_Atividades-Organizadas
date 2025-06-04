int horasNormais, horasExtras;
decimal salarioBruto, salarioLiquido;

Console.WriteLine("Digite a quantidade de horas normais trabalhadas: ");
horasNormais = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas extras trabalhadas: ");
horasExtras = Convert.ToInt32(Console.ReadLine());

salarioBruto = (horasNormais * 10m) + (horasExtras * 15m);

salarioLiquido = salarioBruto * 0.90m;

Console.WriteLine("Salário bruto: R$ " + salarioBruto);
Console.WriteLine("Salário líquido (com 10% de imposto): R$ " + salarioLiquido);