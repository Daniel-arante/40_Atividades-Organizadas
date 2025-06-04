decimal x1, y1, x2, y2;
double distancia;

Console.WriteLine("Digite o valor de x1: ");
x1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de y1: ");
y1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de x2: ");
x2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de y2: ");
y2 = Convert.ToDecimal(Console.ReadLine());

decimal diferencaX = x2 - x1;
decimal diferencaY = y2 - y1;

distancia = Math.Sqrt((double)(diferencaX * diferencaX + diferencaY * diferencaY));

Console.WriteLine("A distância entre os pontos é: " + distancia.ToString("F2"));

//Math.Sqrt = Método para calcular a raiz quadrada de um número.
//Math.Sqrt é um método da classe Math que calcula a raiz quadrada de um número.
//Ele recebe um argumento do tipo double e retorna o resultado como um double. Se o argumento for negativo, o método retornará NaN (Not a Number).

//O método Math.Sqrt() só aceita double, então não é possível calcular a raiz quadrada diretamente com decimal.

//double é um tipo de dado que pode armazenar números com ponto flutuante, permitindo maior precisão em cálculos matemáticos complexos, como a raiz quadrada.