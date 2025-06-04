decimal nota1, nota2, nota3, mediaPoderada;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
nota3 = Convert.ToDecimal(Console.ReadLine());

mediaPoderada = (nota1 * 1 + nota2 * 2 + nota3 * 3) / 6;

Console.WriteLine("A média da nota poderada é " + mediaPoderada);