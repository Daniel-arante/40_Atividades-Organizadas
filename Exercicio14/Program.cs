int raio;
string entrada;
decimal area, pi = 3.14m;

Console.WriteLine("Digite o raio da pizza: ");
entrada = Console.ReadLine();
raio = Convert.ToInt32(Console.ReadLine());

if (raio > 0)
{
    area = pi * raio * raio;
    Console.WriteLine("A área da pizza é: " + area);
}
else
{
    Console.WriteLine("Raio inválido. Digite um valor positivo.");
}