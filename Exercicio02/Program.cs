int quantidadeCavalos, ferraduras;

Console.WriteLine("Digite a quantidade de cavalos");
quantidadeCavalos = Convert.ToInt32(Console.ReadLine());

ferraduras = quantidadeCavalos * 4;

Console.WriteLine("Você vai precisar de " + ferraduras + " ferraduras para equipar os cavalos. ");