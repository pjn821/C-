int n;
double media = 0;

// pedir nota

Console.Write("Digite a quantidade de notas: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Digite a nota " + (i + 1) + ": ");
    double nota = Convert.ToDouble(Console.ReadLine());

    media = media + nota;

}
media = media/n;

// display

Console.WriteLine("\nMedia: " + media);