decimal total, poupanca;
int quantidadePaes = 0, quantidadeBroas = 0;

Console.WriteLine("Digite a quantidade de pães vendidos: ");
quantidadePaes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de broas vendidas: ");
quantidadeBroas = Convert.ToInt32(Console.ReadLine());

total = (quantidadePaes * 0.12m) + (quantidadeBroas * 1.50m);
poupanca = total * 0.10m;

Console.WriteLine("O total arrecadado das vendas é de " + total + " reais");
Console.WriteLine("O valor a guardar na pupança é " + poupanca + " ");