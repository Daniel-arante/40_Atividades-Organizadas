decimal nota1, nota2, mediaPonderada;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

mediaPonderada = (nota1 * 2 + nota2 * 3) / 5;

Console.WriteLine("A média ponderada é: " + mediaPonderada);