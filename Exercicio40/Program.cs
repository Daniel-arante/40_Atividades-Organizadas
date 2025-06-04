double cateto1, cateto2, hipotenusa;

Console.WriteLine("Digite o valor do primeiro cateto: ");
cateto1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo cateto: ");
cateto2 = Convert.ToDouble(Console.ReadLine());

hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);

Console.WriteLine("O valor da hipotenusa é: " + hipotenusa.ToString("F2"));

//double: é um tipo de dado usado para armazenar números com
//casas decimais, ideal para valores que precisam de mais precisão, como medidas.

//Math.Sqrt(): é uma função da biblioteca matemática do C# que calcula a raiz quadrada de um número.
//No código, ela é usada para calcular a hipotenusa, aplicando a fórmula do Teorema de Pitágoras.