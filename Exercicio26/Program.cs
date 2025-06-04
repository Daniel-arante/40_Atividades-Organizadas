decimal num1, num2, num3, resultado;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
num3 = Convert.ToDecimal(Console.ReadLine());

resultado = num1 * num2 * num3;

Console.WriteLine("O resultado dos três números é: " + resultado);