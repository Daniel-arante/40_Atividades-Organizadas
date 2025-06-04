int numero, centena = 0, dezena = 0, unidade = 0;
string entrada;

Console.WriteLine("Digite um número inteiro: ");
entrada = Console.ReadLine();
numero = Convert.ToInt32(entrada);

if (numero >= 0 && numero <= 999)
{
    switch (numero.ToString().Length)
    {
        case 1:
            unidade = numero;
            break;

        case 2:
            dezena = numero / 10;
            unidade = numero % 10;
            break;

        case 3:
            centena = numero / 100;
            dezena = (numero % 100) / 10;
            unidade = numero % 10;
            break;
    }

    Console.WriteLine("Centena = " + centena);
    Console.WriteLine("Dezena = " + dezena);
    Console.WriteLine("Unidade = " + unidade);
}
else
{
    Console.WriteLine("Número inválido. Digite um valor entre 0 e 999.");
}