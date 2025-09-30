double valor;

// qual o valor
Console.Write("qual o valor do produto: ");
valor = Convert.ToDouble(Console.ReadLine());

// verificaçao do valor
valor -= (valor * 0.12);
//valor = valor - (valor * 0.12);

// impressao do valor
Console.WriteLine("O produto custa " + valor + "€");
