decimal comprimento, largura, area;

Console.WriteLine("Digite o comprimentodo seu terreno: ");
comprimento = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a largura do seu terro: ");
largura = Convert.ToDecimal(Console.ReadLine());

area = comprimento * largura;

Console.WriteLine("O tamanho do seu terreno é " + area + " ");