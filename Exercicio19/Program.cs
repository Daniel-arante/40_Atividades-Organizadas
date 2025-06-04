int quantidadeFrangos;
decimal custoTotal;

Console.WriteLine("Digite a quantidade de frangos: ");
quantidadeFrangos = Convert.ToInt32(Console.ReadLine());

custoTotal = quantidadeFrangos * (4.00m + 2 * 3.50m);

Console.WriteLine("Gasto total da granja para marcar os frangos: R$ " + custoTotal);