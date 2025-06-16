decimal precoPorKilo = 12.00m;
decimal pesoPrato, valorFinal;

Console.WriteLine("Digite o peso do prato: ");
pesoPrato = Convert.ToDecimal(Console.ReadLine());

valorFinal = pesoPrato * precoPorKilo;

Console.WriteLine("Valor a pagar: R$ " + valorFinal.ToString("F2"));
