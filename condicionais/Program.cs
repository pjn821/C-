// definir variaveis 
double nota1;
double nota2;
double notatrabalho;
double media;

// entrada/input
Console.Write("digite a nota1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite a nota2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("digite a nota3: ");
notatrabalho = Convert.ToDouble(Console.ReadLine());

// processo/calculo

media = (nota1 * 0.3) + (nota2 * 0.5) + (notatrabalho * 0.2);

// display

Console.WriteLine("\nMédia: " + media);
if (media < 7)
{
    Console.WriteLine("Reprovada!");
}
else
{
     Console.WriteLine("Aprovada!");
}



