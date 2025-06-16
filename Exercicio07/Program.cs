int dia, mes, dias;

Console.WriteLine("Digite o dia: ");
dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o mês: ");
mes = Convert.ToInt32(Console.ReadLine());

dias = (mes - 1) * 30 + dia;

Console.WritLine("Já se passaram " + dias + " dias desde o início do ano.");
