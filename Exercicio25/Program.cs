decimal volume, PI = 3.1416m, raio, altura;

Console.WriteLine("Digite o raio da base da caixa d'água (em metros): ");
raio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa d'água (em metros): ");
altura = Convert.ToDecimal(Console.ReadLine());

volume = PI * raio * raio * altura;

Console.WriteLine("O volume da caixa d'água é:" + volume + "metros cúbicos.");