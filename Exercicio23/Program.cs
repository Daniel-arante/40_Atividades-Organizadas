int repetir;
decimal alturaPessoa, sombraPessoa, sombraPredio, alturaPredio;

alturaPessoa = 1.66m;
repetir = 1;

while (repetir == 1)
{
    Console.WriteLine("Informe o comprimento da sua sombra: ");
    sombraPessoa = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Informe o comprimento da sombra do prédio: ");
    sombraPredio = Convert.ToDecimal(Console.ReadLine());

    if (sombraPessoa > 0 && sombraPredio > 0)
    {
        alturaPredio = (alturaPessoa * sombraPredio) / sombraPessoa;
        Console.WriteLine("A altura estimada do prédio é: " + alturaPredio + " metros.");
        repetir = 0;
    }
    else
    {
        Console.WriteLine("Valores inválidos. Tente novamente.");
    }
}