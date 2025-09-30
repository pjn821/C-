int idade;

// pedir idade

Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

// verificaçao da idade

if (idade >= 18)
{
    Console.WriteLine("Maior de Idade");
}
else
{
    Console.WriteLine("Menor de idade");
}

// par ou impar 
if ((idade % 2) == 0)
{
    Console.WriteLine("numero par");
} else {
    Console.WriteLine("numero impar");
}
