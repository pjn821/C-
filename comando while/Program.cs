int numero;

Console.Write("digite numero inteiro positivo");
numero = Convert.ToInt32(Console.ReadLine());
while (numero < 0)
{
    Console.WriteLine("o numero digitado é negativo");

    Console.Write("digite numero inteiro positivo");
    numero = Convert.ToInt32(Console.ReadLine());
}


// display

Console.WriteLine("o numero: " + numero);
