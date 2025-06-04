decimal precoGasolina, valorPago, litrosAbastecidos;

Console.WriteLine("Digite o preço da gasolina: ");
precoGasolina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor que deve pago: ");
valorPago = Convert.ToDecimal(Console.ReadLine());

if (precoGasolina > 0)
{
    litrosAbastecidos = valorPago / precoGasolina;
    Console.WriteLine($"Você conseguiu encher {litrosAbastecidos:F2} litros no tanque.");
}
else
{
    Console.WriteLine("O preço da gasolina deve ser maior que zero.");
}