using System.Net;



Console.WriteLine("Digite seu nome.");
string user = Console.ReadLine();

Console.WriteLine("qual a sua idade");
string input = Console.ReadLine();

int years;
if (int.TryParse(input, out years))
{
    Console.WriteLine("Olá " + user + ", tens " + years + " anos.");dop
}
else
{
    Console.WriteLine(" Digite apenas números!");
    
}


