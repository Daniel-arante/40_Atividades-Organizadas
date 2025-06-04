Console.WriteLine("Digite a quantidade de dias sem acidentes: ");
int dias = Convert.ToInt32(Console.ReadLine());

if (dias >= 0)
{
    Console.WriteLine("Tempo sem acidentes:");
    Console.WriteLine("Anos: " + (dias / 360));
    Console.WriteLine("Meses: " + ((dias % 360) / 30));
    Console.WriteLine("Dias: " + ((dias % 360) % 30));
}
else
{
    Console.WriteLine("Número inválido. O valor deve ser positivo.");
}
