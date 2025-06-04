decimal numero1, numero2, resultado;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToDecimal(Console.ReadLine());

resultado = numero1 / numero2;

Console.WriteLine("O resultado da divisão é: " + resultado);