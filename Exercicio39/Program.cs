decimal salario = 1200.0m, conta1 = 120.0m, conta2 = 120.0m, multa = 0.02m;
decimal totalMulta, totalContasComMulta, salarioRestante;

totalMulta = (conta1 + conta2) * multa;
totalContasComMulta = (conta1 + conta2) + totalMulta;
salarioRestante = salario - totalContasComMulta;

Console.WriteLine("Salário inicial: R$ " + salario.ToString("F2"));
Console.WriteLine("Valor total das contas com multa: R$ " + totalContasComMulta.ToString("F2"));
Console.WriteLine("Salário restante após pagamento: R$ " + salarioRestante.ToString("F2"));