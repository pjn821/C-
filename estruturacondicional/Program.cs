using System.Reflection.PortableExecutable;

double salario;
double aliquota;
double deducao;
double impostomensal;
double impostoanual;

// obtencao dos valores

Console.Write("qual o seu salario:");
salario = Convert.ToDouble(Console.ReadLine());

// calaculo 
if (salario > 4664.68)
{
    aliquota = 27.5;
    deducao = 869.36;
    // faixa 5
}
else if (salario <= 4664.68 && salario >= 3751.06)
{
    aliquota = 22.5;
    deducao = 636.13;
    //faixa 4
}
else if (salario <= 3751.06 && salario >= 2826.65)
{
    aliquota = 15;
    deducao = 354.80;
    //faixa 3 
}
else if (salario <= 2826.65 && salario >= 1903.99)
{
    aliquota = 7.5;
    deducao = 142.80;
    //faixa2 
}
else
{
    aliquota = 0;
    deducao = 0;
    //faixa1
    
}

impostomensal = salario* (aliquota/100) - deducao;
impostoanual = impostomensal * 12;

// display

Console.WriteLine("Seu Salario Mensal: " + salario + "€");
Console.WriteLine("Sua Aliquota: " + aliquota + "%");
Console.WriteLine("Sua Dedução: " + deducao + "€");
Console.WriteLine("Seu Imposto Mensal: " + impostomensal + "€");
Console.WriteLine("Seu Imposto Anual: " + impostoanual + "€");