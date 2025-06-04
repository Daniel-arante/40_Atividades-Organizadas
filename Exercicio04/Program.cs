string nome;
int suaIdade, diasVida;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
suaIdade = Convert.ToInt32(Console.ReadLine());

if (suaIdade >= 0)
{
    diasVida = suaIdade * 365;
    Console.WriteLine("" + nome + " já viveu " + diasVida + " dias.");
}

else
{
    Console.WriteLine("Idade inválidade, digite um valor positivo.");
}