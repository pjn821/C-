int n;
double media = 0;

// pedir nota

Console.Write("Digite a quantidade de notas: ");
n = Convert.ToInt32(Console.ReadLine()); // n <- 0

// quando utilizador responde 0
// = -> atribuir valor a variavel
// == -> fazer comparacao

if (n == 0)
{
Console.WriteLine("Nao ha notas");
}
else
{
   for (int i = 0; i < n; i++)
{
    Console.Write("Digite a nota " + (i + 1) + ": ");
    double nota = Convert.ToDouble(Console.ReadLine());

    media = media + nota;
    // fazer for loop aqui dentro
}

}
media = media/n;

// display

Console.WriteLine("\nMedia: " + media);