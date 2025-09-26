// definir variaveis 
double nota1;
double nota2;
double nota3;
double nota4;
double media;

// entrada/input
Console.Write("digite a nota1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite a nota2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite a nota3: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite a nota4: ");
nota4 = Convert.ToDouble(Console.ReadLine());

// processo/calculo

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("\nMédia: " + media);