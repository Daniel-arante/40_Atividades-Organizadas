int repetir;
decimal totalRefresco, litrosAgua, litrosSuco;

repetir = 1;

while (repetir == 1)
{
    Console.WriteLine("Informe a quantidade total de refresco a ser preparada em litros: ");
    totalRefresco = Convert.ToDecimal(Console.ReadLine());

    if (totalRefresco > 0)
    {
        litrosAgua = totalRefresco * 0.8m;
        litrosSuco = totalRefresco * 0.2m;

        Console.WriteLine("Para preparar " + totalRefresco + " litros de refresco:");
        Console.WriteLine(" - Água necessária: " + litrosAgua + " litros");
        Console.WriteLine(" - Suco necessário: " + litrosSuco + " litros");

        repetir = 0;
    }
    else
    {
        Console.WriteLine("Valor inválido. Tente novamente.");
    }
}