decimal celsius, fahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius: ");
celsius = Convert.ToDecimal(Console.ReadLine());

fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine( + celsius + "°C equivale a " + fahrenheit +  "°F. ");

// Fórmula para converter Celsius para Fahrenheit:
// Fahrenheit = (Celsius * 9/5) + 32