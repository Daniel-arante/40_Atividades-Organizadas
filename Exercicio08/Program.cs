﻿decimal nota1, nota2, nota3, mediaPonderada;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
nota3 = Convert.ToDecimal(Console.ReadLine());

mediaPonderada = (nota1 * 1 + nota2 * 2 + nota3 * 3) / 6;

Console.WriteLine("A média da nota ponderada é " + mediaPonderada);
