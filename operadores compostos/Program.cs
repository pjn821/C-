int calorias;

// quntas calorias
Console.Write("quantidade de calorias consumidas hoje: ");
calorias = Convert.ToInt32(Console.ReadLine());

// verificar calorias 

if (calorias > 1200 && calorias < 1900)
{
    Console.WriteLine("Dentro da faixa");
}
else
{
    Console.WriteLine("fora da faixa");
}