int quantidadePequena, quantidadeMedia, quantidadeGrande;
decimal total, precoPequena = 10, precoMedia = 12, precoGrande = 15;

Console.WriteLine("Digite a quantidade de camisetas pequenas que foram vendidas");
quantidadePequena = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de camisetas médias que foram vendidas");
quantidadeMedia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de camisetas grandes que foram vendidas");
quantidadeGrande = Convert.ToInt32(Console.ReadLine());

if (quantidadePequena >= 0 && quantidadeMedia >= 0 && quantidadeGrande >= 0)
{
    total = quantidadePequena * precoPequena + quantidadeMedia * precoMedia * quantidadeGrande * precoGrande;
    Console.WriteLine("valor total arrecado: R$ " + total);
}