int quantidadeBlusas;
decimal totalNovelos, novelosPorBlusa;

Console.WriteLine("Digite a quantidade de blusas produzidas: ");
quantidadeBlusas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade total de novelos usados: ");
totalNovelos = Convert.ToDecimal(Console.ReadLine());

if (quantidadeBlusas > 0)
{
    novelosPorBlusa = totalNovelos / quantidadeBlusas;
    Console.WriteLine("Quantidade de novelos por blusa: " + novelosPorBlusa);
}
else
{
    Console.WriteLine("A quantidade de blusas deve ser maior que zero.");
}