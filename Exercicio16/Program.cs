int quantidadeSanduiches, repetir;
decimal pesoQueijo, pesoPresunto, pesoCarne;

repetir = 1;

while (repetir == 1)
{
    Console.WriteLine("Digite a quantidade de sanduíches a fazer: ");
    quantidadeSanduiches = Convert.ToInt32(Console.ReadLine());

    if (quantidadeSanduiches > 0)
    {
        pesoQueijo = (2 * 50 * quantidadeSanduiches) / 1000m;
        pesoPresunto = (1 * 50 * quantidadeSanduiches) / 1000m;
        pesoCarne = (1 * 100 * quantidadeSanduiches) / 1000m;

        Console.WriteLine("Quantidade de ingredientes necessários: ");
        Console.WriteLine("Queijo: " + pesoQueijo + " kg ");
        Console.WriteLine("Presunto: " + pesoPresunto + " kg ");
        Console.WriteLine("Carne: " + pesoCarne + " kg ");

        repetir = 0;
    }
    else
    {
        Console.WriteLine("Valor inválido. Deseja tentar novamente? (1 para sim, 0 para não): ");
        repetir = Convert.ToInt32(Console.ReadLine());
    }
}