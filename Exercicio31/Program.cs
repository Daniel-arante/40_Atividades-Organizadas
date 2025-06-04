decimal peso, pesoEngordar, pesoEmagrecer;

Console.WriteLine("Digite o peso da pessoa: ");
peso = Convert.ToDecimal(Console.ReadLine());

pesoEngordar = peso + (peso * 0.15m);   
pesoEmagrecer = peso - (peso * 0.20m);  

Console.WriteLine($"Peso se engordar 15%: {pesoEngordar:F2} kg");
Console.WriteLine($"Peso se emagrecer 20%: {pesoEmagrecer:F2} kg");