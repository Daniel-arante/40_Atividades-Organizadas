decimal baseMaior, baseMenor, altura, area;

Console.WriteLine("Digite a base maior:");
baseMaior = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a base menor:");
baseMenor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura:");
altura = Convert.ToDecimal(Console.ReadLine());

area = (baseMaior + baseMenor) * altura / 2;

Console.WriteLine("A área do trapézio é: " + area.ToString("F2") + " m²");