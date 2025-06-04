int numero, contador = 1, opcao = 1;

while (opcao == 1)
{
    Console.WriteLine("Digite um número para ver a tabuada:");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero >= 0)
    {
        Console.WriteLine("Tabuada do " + numero + ":");
        contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
            contador++;
        }
    }
    else
    {
        Console.WriteLine("Número inválido. Digite um número positivo ou zero.");
    }

    Console.WriteLine("Quer ver a tabuada de outro número?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Show, vamos para a próxima!");
            break;
        case 2:
            Console.WriteLine("Valeu! Até a próxima.");
            break;
        default:
            Console.WriteLine("Entrada inválida, encerrando o programa.");
            opcao = 2;
            break;
    }
}